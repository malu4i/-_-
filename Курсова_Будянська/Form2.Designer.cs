namespace Курсова_Будянська
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
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
            label1 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(260, 78);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 1;
            label2.Text = "Ім'я";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(260, 118);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 2;
            label3.Text = "Прізвище";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(260, 160);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 3;
            label4.Text = "Дата народження";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(260, 199);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 4;
            label5.Text = "Посада";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(260, 237);
            label6.Name = "label6";
            label6.Size = new Size(130, 21);
            label6.TabIndex = 5;
            label6.Text = "Номер телефону";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(410, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(410, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(410, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(410, 235);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 23);
            textBox5.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(410, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(410, 314);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 13;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(12, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(796, 184);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, fileToolStripMenuItem, employeeToolStripMenuItem, salaryToolStripMenuItem, scheduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(820, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(52, 20);
            logOutToolStripMenuItem.Text = "Вийти";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
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
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(122, 22);
            openToolStripMenuItem.Text = "Відкрити";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
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
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // salaryToolStripMenuItem
            // 
            salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            salaryToolStripMenuItem.Size = new Size(77, 20);
            salaryToolStripMenuItem.Text = "Зарплатня";
            salaryToolStripMenuItem.Click += salaryToolStripMenuItem_Click;
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(63, 20);
            scheduleToolStripMenuItem.Text = "Розклад";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(343, 38);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Інформація";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(260, 276);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 16;
            label7.Text = "Ставка у день";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(410, 274);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 23);
            textBox3.TabIndex = 17;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID працівника";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 150F;
            Column2.HeaderText = "Ім'я";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Прізвище";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Дата народження";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 150F;
            Column5.HeaderText = "Посада";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Телефон";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(820, 566);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Додавання робітника";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem salaryToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private Label label7;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}