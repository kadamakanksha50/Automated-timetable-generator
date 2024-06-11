namespace AutomatedTimeTable
{
    partial class TeacherLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            txtpwd = new TextBox();
            label4 = new Label();
            txtuser = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 50);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(493, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 50);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 50);
            label1.TabIndex = 0;
            label1.Text = "Teacher Login";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(115, 296);
            button1.Name = "button1";
            button1.Size = new Size(333, 69);
            button1.TabIndex = 11;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtpwd
            // 
            txtpwd.BorderStyle = BorderStyle.FixedSingle;
            txtpwd.Location = new Point(113, 216);
            txtpwd.Name = "txtpwd";
            txtpwd.PasswordChar = '*';
            txtpwd.Size = new Size(335, 34);
            txtpwd.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(113, 185);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // txtuser
            // 
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Location = new Point(113, 135);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(335, 34);
            txtuser.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 100);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // TeacherLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtpwd);
            Controls.Add(label4);
            Controls.Add(txtuser);
            Controls.Add(label3);
            Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TeacherLogin";
            Size = new Size(543, 446);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox txtpwd;
        private Label label4;
        private TextBox txtuser;
        private Label label3;
    }
}
