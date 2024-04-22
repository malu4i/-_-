namespace Курсова_Будянська
{
    partial class Form7
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
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
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
            EmployeeID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            DayRate = new DataGridViewTextBoxColumn();
            Days = new DataGridViewTextBoxColumn();
            Bonus = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(614, 409);
            button2.Name = "button2";
            button2.Size = new Size(126, 29);
            button2.TabIndex = 27;
            button2.Text = "Зберегти зміни";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, Column1, Column2, Column3, DayRate, Days, Bonus, Salary });
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 305);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "\"MM/yyyy\"";
            dateTimePicker1.Location = new Point(12, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 28;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, fileToolStripMenuItem, employeeToolStripMenuItem, salaryToolStripMenuItem, scheduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 29;
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
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
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
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
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
            // EmployeeID
            // 
            EmployeeID.HeaderText = "ID співробітника";
            EmployeeID.Name = "EmployeeID";
            // 
            // Column1
            // 
            Column1.HeaderText = "Ім'я";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Прізвище";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Посада";
            Column3.Name = "Column3";
            // 
            // DayRate
            // 
            DayRate.HeaderText = "Ставка в день";
            DayRate.Name = "DayRate";
            // 
            // Days
            // 
            Days.FillWeight = 70F;
            Days.HeaderText = "Дні";
            Days.Name = "Days";
            Days.Width = 70;
            // 
            // Bonus
            // 
            Bonus.HeaderText = "Премія";
            Bonus.Name = "Bonus";
            // 
            // Salary
            // 
            Salary.HeaderText = "Зарплатня";
            Salary.Name = "Salary";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "Form7";
            Text = "Зарплатня";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
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
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn DayRate;
        private DataGridViewTextBoxColumn Days;
        private DataGridViewTextBoxColumn Bonus;
        private DataGridViewTextBoxColumn Salary;
    }
}