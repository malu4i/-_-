namespace Курсова_Будянська
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(110, 46);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 2;
            label1.Text = "Головна";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(113, 104);
            button1.Name = "button1";
            button1.Size = new Size(102, 35);
            button1.TabIndex = 1;
            button1.Text = "Увійти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(113, 243);
            button2.Name = "button2";
            button2.Size = new Size(102, 39);
            button2.TabIndex = 3;
            button2.Text = "Закрити";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(113, 171);
            button3.Name = "button3";
            button3.Size = new Size(102, 39);
            button3.TabIndex = 4;
            button3.Text = "Інформація";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(334, 341);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Головна";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}