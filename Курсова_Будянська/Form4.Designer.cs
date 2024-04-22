namespace Курсова_Будянська
{
    partial class Form4
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
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
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(75, 49);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 18;
            label1.Text = "Хто працює?";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column4, Column1, Column2, Column3 });
            dataGridView1.Location = new Point(75, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(641, 222);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(641, 361);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 20;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(517, 361);
            button2.Name = "button2";
            button2.Size = new Size(80, 31);
            button2.TabIndex = 21;
            button2.Text = "Змінити";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, fileToolStripMenuItem, employeeToolStripMenuItem, salaryToolStripMenuItem, scheduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 22;
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
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
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
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
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
            // 
            // Column4
            // 
            Column4.FillWeight = 130F;
            Column4.HeaderText = "ID співробітника";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 130;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ім'я";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Прізвище";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Посада";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form4";
            Text = "Розклад";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
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
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}