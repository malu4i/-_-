using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.Xml;


namespace Курсова_Будянська
{
    public partial class Form2 : Form
    {
        Data dt = new Data();

        public Form2()
        {
            InitializeComponent();
            string message = "Обов'язково створіть або відкрийте існуючу базу";
            string title = "Повідомлення";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            MessageBox.Show(message, title, buttons, icon);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                SqlConnection con = new SqlConnection(Data.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees VALUES ( @FirstName, @LastName, @BirthDate, @Position, @Phone, @DayRate)", con);
                //cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                cmd.Parameters.AddWithValue("@BirthDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Position", textBox4.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox5.Text);
                cmd.Parameters.AddWithValue("@DayRate", Convert.ToDecimal(textBox3.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved");
                LocalData();
            }
            catch (Exception ex)
            {
                // Обработка и отображение сообщения об ошибке
                string errorMessage = "Обов'язково створіть або відкрийте існуючу базу";
                MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LocalData()
        {
            try
            {
                dataGridView1.Rows.Clear();
                SqlConnection con = new SqlConnection(Data.con);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employees ORDER BY EmployeeID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

