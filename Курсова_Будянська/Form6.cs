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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсова_Будянська
{
    public partial class Form6 : Form

    {
        List<int> check = new List<int>();

        public Form6()
        {
            InitializeComponent();
            LocalData();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void LocalData()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checking();
            string message = "Do you want to do this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(Data.con);
                con.Open();
                SqlCommand cmd = new SqlCommand($"DELETE Schedule  WHERE Date=@DateTime", con);
                cmd.Parameters.AddWithValue("@DateTime", Data.dateTime);
                cmd.ExecuteNonQuery();
                foreach (int index in check)
                {
                    SqlCommand cdm = new SqlCommand($"INSERT INTO Schedule (EmployeeID, Date) VALUES (@EmployeeID, @Date)", con);
                    cdm.Parameters.AddWithValue("@EmployeeID", index);
                    cdm.Parameters.AddWithValue("@Date", Data.dateTime);
                    cdm.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Successfully saved");
                check.Clear();
                Form4 f4 = new Form4();
                f4.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();

        }
        private void checking()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[6] as DataGridViewCheckBoxCell;

                // Проверяем, что checkBoxCell и значение не равны null
                if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value == true)
                {
                    // Проверяем, что значение в столбце EmployeeID не равно null
                    if (row.Cells[0].Value != null)
                    {
                        // Получаем значение EmployeeID из первого столбца (предположим, что он находится в столбце с индексом 0)
                        int employeeID = Convert.ToInt32(row.Cells[0].Value);

                        // Добавляем в лист check
                        check.Add(employeeID);
                    }
                }
            }

        }

    }

}
