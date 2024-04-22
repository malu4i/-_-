using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_Будянська
{
    public partial class Form5 : Form
    {
        private SqlDataAdapter SqlDataAdapter = null;
        Data dt = new Data();
        public Form5()
        {
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void LocalData(string s)
        {
            try
            {
                dataGridView1.Rows.Clear();
                SqlConnection con = new SqlConnection(Data.con);
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Employees WHERE CONCAT(FirstName,LastName,BirthDate,Position,Phone) like '%{s}%' ORDER BY EmployeeID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();


                }
                reader.Close();
                con.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

            string str = textBox1.Text;
            LocalData(str);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int cellValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    Data.id_num = cellValue;
                    Form3 f3 = new Form3();
                    f3.Show();

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




        }

        private void label1_Click(object sender, EventArgs e)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}