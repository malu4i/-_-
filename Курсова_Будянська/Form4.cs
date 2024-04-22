using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_Будянська
{
    public partial class Form4 : Form
    {
        List<string[]> data = new List<string[]>();
        Data dt = new Data();

        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                data.Clear();
                Data.dateTime = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                string message = Convert.ToString(Data.dateTime);
                string title = "Обрати цю дату?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                SqlConnection con = new SqlConnection(Data.con);
                con.Open();
                string query = "SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName, Employees.Position " +
                   "FROM Employees " +
                   "JOIN Schedule ON Employees.EmployeeID = Schedule.EmployeeID " +
                   "WHERE Schedule.Date = @DateTime";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@DateTime", Data.dateTime);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] row = new string[4];

                        row[0] = reader[0].ToString();
                        row[1] = reader[1].ToString();
                        row[2] = reader[2].ToString();
                        row[3] = reader[3].ToString();

                        data.Add(row);
                    }
                    reader.Close();
                    con.Close();


                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                foreach (string[] str in data)
                {
                    dataGridView1.Rows.Add(str);
                }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Close();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.newData();

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dt.openData();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Close();
        }
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }
    }
}
