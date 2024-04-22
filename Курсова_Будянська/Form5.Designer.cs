namespace Курсова_Будянська
{
    partial class Form5
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 23);
            textBox1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(12, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 258);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(385, 36);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 20;
            label1.Text = "Знайти";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(679, 106);
            button1.Name = "button1";
            button1.Size = new Size(72, 27);
            button1.TabIndex = 21;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, fileToolStripMenuItem, employeeToolStripMenuItem, salaryToolStripMenuItem, scheduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(113, 22);
            findToolStripMenuItem.Text = "Знайти";
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
            // Column1
            // 
            Column1.FillWeight = 130F;
            Column1.HeaderText = "ID співробітника";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ім'я";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Прізвище";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 130F;
            Column4.HeaderText = "Дата народження";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.HeaderText = "Посада";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Телефон";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "Form5";
            Text = "Знайти працівника";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}