namespace Курсова_Будянська
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            salaryToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(323, 47);
            label1.Name = "label1";
            label1.Size = new Size(128, 30);
            label1.TabIndex = 1;
            label1.Text = "Інформація";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(457, 364);
            button1.Name = "button1";
            button1.Size = new Size(86, 38);
            button1.TabIndex = 2;
            button1.Text = "Видалити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(219, 364);
            button2.Name = "button2";
            button2.Size = new Size(86, 38);
            button2.TabIndex = 3;
            button2.Text = "Редагувати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(263, 251);
            label6.Name = "label6";
            label6.Size = new Size(130, 21);
            label6.TabIndex = 21;
            label6.Text = "Номер телефону";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(266, 211);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 20;
            label5.Text = "Посада";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(266, 172);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 19;
            label4.Text = "Дата народження";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(266, 131);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 18;
            label3.Text = "Прізвище";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(266, 96);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 17;
            label2.Text = "Ім'я";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(411, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 28;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(411, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 30;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(411, 249);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 23);
            textBox5.TabIndex = 31;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(301, 306);
            button3.Name = "button3";
            button3.Size = new Size(80, 32);
            button3.TabIndex = 32;
            button3.Text = "Зберегти";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(411, 306);
            button4.Name = "button4";
            button4.Size = new Size(78, 32);
            button4.TabIndex = 33;
            button4.Text = "Скасувати";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 27;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, fileToolStripMenuItem, employeeToolStripMenuItem, salaryToolStripMenuItem, scheduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(52, 20);
            logOutToolStripMenuItem.Text = "Вийти";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click_1;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(122, 22);
            newToolStripMenuItem.Text = "Новий";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click_1;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(122, 22);
            openToolStripMenuItem.Text = "Відкрити";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertToolStripMenuItem, findToolStripMenuItem });
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(77, 20);
            employeeToolStripMenuItem.Text = "Працівник";
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(113, 22);
            insertToolStripMenuItem.Text = "Додати";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(113, 22);
            findToolStripMenuItem.Text = "Знайти";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click_1;
            // 
            // salaryToolStripMenuItem
            // 
            salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            salaryToolStripMenuItem.Size = new Size(77, 20);
            salaryToolStripMenuItem.Text = "Зарплатня";
            salaryToolStripMenuItem.Click += salaryToolStripMenuItem_Click_1;
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(63, 20);
            scheduleToolStripMenuItem.Text = "Розклад";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(411, 170);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(117, 23);
            dateTimePicker1.TabIndex = 35;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Профіль";
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem salaryToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
    }
}