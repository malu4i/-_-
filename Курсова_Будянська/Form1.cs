namespace Курсова_Будянська
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inf form = new inf();
            form.Show();
            this.Hide();
        }
    }
}