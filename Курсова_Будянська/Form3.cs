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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсова_Будянська
{
    public partial class Form3 : Form
    {
        bool edited = false;
        Data dt = new Data();
        public Form3()
        {
            InitializeComponent();
            LocalData();
        }
        private void LocalData()
        {

            int ids = Data.id_num;
            MessageBox.Show(Convert.ToString(ids));
            SqlConnection con = new SqlConnection(Data.con);
            string query = $"SELECT * FROM Employees WHERE EmployeeID = {ids}";
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Добавляем параметр для предотвращения SQL-инъекций


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Пример: извлечение данных из всех столбцов
                        string FName = reader.GetString(reader.GetOrdinal("FirstName")); // Замените на реальное имя столбца
                        string LName = reader.GetString(reader.GetOrdinal("LastName"));
                        DateTime BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                        string Position = reader.GetString(reader.GetOrdinal("Position"));
                        string Phone = reader.GetString(reader.GetOrdinal("Phone"));

                        // Здесь вы можете использовать значения, например, установить их в TextBox
                        textBox1.Text = FName;
                        textBox2.Text = LName;
                        dateTimePicker1.Value = BirthDate;
                        textBox4.Text = Position;
                        textBox5.Text = Phone;
                    }
                    else
                    {
                        string message = "Ne nashlo!";
                        MessageBox.Show(message);
                    }
                }
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (edited == false)
            {
                textBox1.ReadOnly = true;
            }
            else { textBox1.ReadOnly = false; }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (edited == false)
            {
                textBox2.ReadOnly = true;
            }
            else { textBox2.ReadOnly = false; }
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (edited == false)
            {
                textBox4.ReadOnly = true;
            }
            else { textBox4.ReadOnly = false; }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (edited == false)
            {
                textBox5.ReadOnly = true;
            }
            else { textBox5.ReadOnly = false; }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            edited = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            button3.Visible = true;
            button4.Visible = true;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to do this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(Data.con))
                {
                    con.Open();

                    // Создаем SQL-запрос с параметрами
                    string updateQuery = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate, Position = @Position, Phone = @Phone WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        // Привязываем параметры
                        cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Position", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Phone", textBox5.Text);

                        // Привязываем параметр @EmployeeID
                        cmd.Parameters.AddWithValue("@EmployeeID", Data.id_num);

                        // Привязываем команду к соединению
                        cmd.Connection = con;

                        // Выполняем запрос
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully saved");
                            this.Close();
                            button3.Visible = false;
                            button4.Visible = false;
                            edited = false;
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Check the values you entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Do you want to abort this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Abort)
            {
                this.Close();
                button3.Visible = false;
                button4.Visible = false;
                edited = false;
            }
            else if (result == DialogResult.Retry)
            {
                // Do nothing
            }
            else
            {
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to do this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(Data.con);
                con.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM Employees WHERE EmployeeID = {Data.id_num}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully deleted");
                this.Close();
                button3.Visible = false;
                button4.Visible = false;
                edited = false;
                this.Close();
            }

            else
            {
                this.Close();
            }
        }


        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Program.f1.Show();
            this.Close();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dt.openData();
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dt.newData();
        }

        private void salaryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        private void scheduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void findToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (edited == false)
            {
                dateTimePicker1.Enabled = true;
            }
            else { dateTimePicker1.Enabled = false; }
        }
    }
}
