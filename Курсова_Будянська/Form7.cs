using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_Будянська
{
    public partial class Form7 : Form
    {
        public int yourMonthValue;
        public int yourYearValue;
        Data dt = new Data();
        public Form7()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            // Получаем месяц и год из выбранной даты
            yourMonthValue = selectedDate.Month;
            yourYearValue = selectedDate.Year;
            try
            {
                LocalData(yourMonthValue, yourYearValue);
            }
            catch (Exception ex)
            {
                // Обработка и отображение сообщения об ошибке
                string errorMessage = "Обов'язково створіть або відкрийте існуючу базу";
                MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Опционально: Вывод дополнительной информации об ошибке в консоль
                Console.WriteLine($"Exception details: {ex}");
            }
        }

        // Метод для установки формата
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
        }
        private void LocalData(int yourMonthValue, int yourYearValue)
        {

            dataGridView1.Rows.Clear();

            string connectionString = Data.con;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
            SELECT 
                E.EmployeeID,
                E.FirstName,
                E.LastName,
                E.Position,
                E.DayRate,
                COUNT(DISTINCT S.Date) AS DaysPerMonth,
                SI.Bonus,
                E.DayRate * COUNT(DISTINCT S.Date) + ISNULL(SI.Bonus, 0) AS Salary
            FROM 
                Employees E
            LEFT JOIN 
                SalaryInfo SI ON E.EmployeeID = SI.EmployeeID
            LEFT JOIN 
                Schedule S ON E.EmployeeID = S.EmployeeID AND MONTH(S.Date) = @Month AND YEAR(S.Date) = @Year
            WHERE 
                MONTH(S.Date) = @Month AND YEAR(S.Date) = @Year
            GROUP BY 
                E.EmployeeID, E.FirstName, E.LastName, E.Position, E.DayRate, SI.Bonus;
        ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Month", yourMonthValue);
                    cmd.Parameters.AddWithValue("@Year", yourYearValue);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<string[]> data = new List<string[]>();
                        while (reader.Read())
                        {
                            string[] row = new string[8];
                            row[0] = reader[0].ToString();
                            row[1] = reader[1].ToString();
                            row[2] = reader[2].ToString();
                            row[3] = reader[3].ToString();
                            row[4] = reader[4].ToString();
                            row[5] = reader[5].ToString();  // DaysPerMonth
                            row[6] = reader[6].ToString();
                            row[7] = reader[7].ToString();
                            data.Add(row);
                        }

                        reader.Close();

                        foreach (string[] str in data)
                        {
                            dataGridView1.Rows.Add(str);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { LocalData(yourMonthValue, yourYearValue); }
            catch (Exception ex)
            {
                // Обработка и отображение сообщения об ошибке
                string errorMessage = "Обов'язково створіть або відкрийте існуючу базу";
                MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Опционально: Вывод дополнительной информации об ошибке в консоль
                Console.WriteLine($"Exception details: {ex}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try { SaveChangesToDatabase(); }
            catch (Exception ex)
            {
                // Обработка и отображение сообщения об ошибке
                string errorMessage = "Обов'язково створіть або відкрийте існуючу базу";
                MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Опционально: Вывод дополнительной информации об ошибке в консоль
                Console.WriteLine($"Exception details: {ex}");
            }



        }

        private void SaveChangesToDatabase()
        {
            string connectionString = Data.con;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                CultureInfo cultureInfo = new CultureInfo("fr-FR");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (!row.IsNewRow)
                    {
                        int employeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                        decimal dayrate = Convert.ToDecimal(row.Cells["DayRate"].Value);
                        string bonusString = row.Cells["Bonus"].Value.ToString();
                        decimal bonus;
                        if (decimal.TryParse(bonusString, NumberStyles.Any, cultureInfo, out bonus))
                        {
                            bonus = Convert.ToDecimal(row.Cells["Bonus"].Value);
                        }
                        else
                        {
                            // Строка пуста или не может быть преобразована в decimal
                            bonus = 0;
                        }
                        
                        decimal salary = Convert.ToDecimal(row.Cells["Salary"].Value);
                        int dayspermounth = Convert.ToInt32(row.Cells["Days"].Value);

                        // Создаем SQL-запрос для вставки данных в таблицу SalaryInfo
                        string insertQuery = @"
                    INSERT INTO SalaryInfo (DaysPerMonth, EmployeeID, Bonus, Salary )
                    
                    VALUES (@DaysPerMonth, @EmployeeID, @Bonus, @Salary);
                ";

                        // Создаем команду SQL
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                        {
                            // Добавляем параметры
                            insertCmd.Parameters.AddWithValue("@DaysPerMonth", dayspermounth);
                            insertCmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                            insertCmd.Parameters.AddWithValue("@Bonus", bonus);
                            insertCmd.Parameters.AddWithValue("@Salary", salary);

                            // Выполняем запрос
                            insertCmd.ExecuteNonQuery();
                        }
                        string sqlUpdate = @"UPDATE Employees SET DayRate = @DayRate WHERE EmployeeID = @EmployeeID";

                        using (SqlCommand command = new SqlCommand(sqlUpdate, connection))
                        {
                            // Додавання параметрів до запиту
                            command.Parameters.AddWithValue("@DayRate", dayrate);
                            command.Parameters.AddWithValue("@EmployeeID", employeeID);

                            command.ExecuteNonQuery();

                        }
                    }

                }
                connection.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }










        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dt.newData();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dt.openData();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Close();
        }

        private void findToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Close();
        }

        private void salaryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Close();
        }

        private void scheduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}

