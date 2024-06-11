namespace AutomatedTimeTable
{
    partial class SemesterCirculum
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
            label3 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelHoliday = new Panel();
            button4 = new Button();
            cmbHoliday = new ComboBox();
            label4 = new Label();
            panelSubmission = new Panel();
            button6 = new Button();
            comboBox3 = new ComboBox();
            label6 = new Label();
            panelMidTest = new Panel();
            button5 = new Button();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panelHoliday.SuspendLayout();
            panelSubmission.SuspendLayout();
            panelMidTest.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1157, 57);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1097, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 57);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 57);
            label1.TabIndex = 0;
            label1.Text = "Semester Ciriculum";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 95);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 1;
            label3.Text = "Academic Year :";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(175, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 36);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(18, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1078, 96);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ciriculum Actions";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(741, 33);
            button3.Name = "button3";
            button3.Size = new Size(307, 44);
            button3.TabIndex = 4;
            button3.Text = "Add/View Submission Schedule";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(464, 33);
            button2.Name = "button2";
            button2.Size = new Size(271, 44);
            button2.TabIndex = 1;
            button2.Text = "Add/View Mid Test Schedule";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(191, 33);
            button1.Name = "button1";
            button1.Size = new Size(267, 44);
            button1.TabIndex = 0;
            button1.Text = "Add/View Weekly Holiday";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelHoliday
            // 
            panelHoliday.Controls.Add(button4);
            panelHoliday.Controls.Add(cmbHoliday);
            panelHoliday.Controls.Add(label4);
            panelHoliday.Location = new Point(21, 257);
            panelHoliday.Name = "panelHoliday";
            panelHoliday.Size = new Size(1075, 399);
            panelHoliday.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(421, 306);
            button4.Name = "button4";
            button4.Size = new Size(311, 44);
            button4.TabIndex = 2;
            button4.Text = "Add Weekly Holiday";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // cmbHoliday
            // 
            cmbHoliday.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHoliday.FlatStyle = FlatStyle.System;
            cmbHoliday.FormattingEnabled = true;
            cmbHoliday.Items.AddRange(new object[] { "SELECT", "Thursday", "Sunday", "Saturday and Sunday" });
            cmbHoliday.Location = new Point(421, 48);
            cmbHoliday.Name = "cmbHoliday";
            cmbHoliday.Size = new Size(311, 36);
            cmbHoliday.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(188, 49);
            label4.Name = "label4";
            label4.Size = new Size(224, 28);
            label4.TabIndex = 0;
            label4.Text = "Select Weekly Holiday :";
            // 
            // panelSubmission
            // 
            panelSubmission.Controls.Add(button6);
            panelSubmission.Controls.Add(comboBox3);
            panelSubmission.Controls.Add(label6);
            panelSubmission.Location = new Point(18, 257);
            panelSubmission.Name = "panelSubmission";
            panelSubmission.Size = new Size(1075, 399);
            panelSubmission.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkCyan;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(421, 306);
            button6.Name = "button6";
            button6.Size = new Size(311, 44);
            button6.TabIndex = 2;
            button6.Text = "Add Submission Schedule";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.System;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "SELECT", "Last 15 days", "Last 20 days", "Last 30 days", "Last 40 days" });
            comboBox3.Location = new Point(474, 48);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(311, 36);
            comboBox3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(188, 49);
            label6.Name = "label6";
            label6.Size = new Size(277, 28);
            label6.TabIndex = 0;
            label6.Text = "Select Submission Schedule :";
            // 
            // panelMidTest
            // 
            panelMidTest.Controls.Add(button5);
            panelMidTest.Controls.Add(comboBox2);
            panelMidTest.Controls.Add(label5);
            panelMidTest.Location = new Point(18, 257);
            panelMidTest.Name = "panelMidTest";
            panelMidTest.Size = new Size(1075, 399);
            panelMidTest.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(421, 306);
            button5.Name = "button5";
            button5.Size = new Size(311, 44);
            button5.TabIndex = 2;
            button5.Text = "Add Mid Test Schedule";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SELECT", "After 50% of Duration", "After 75% of Duration", "After 90% of Duration" });
            comboBox2.Location = new Point(443, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(311, 36);
            comboBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(188, 49);
            label5.Name = "label5";
            label5.Size = new Size(249, 28);
            label5.TabIndex = 0;
            label5.Text = "Select Mid Test Schedule :";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FlatStyle = FlatStyle.System;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(691, 92);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(348, 36);
            comboBox4.TabIndex = 8;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(579, 95);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 7;
            label7.Text = "Semester :";
            // 
            // SemesterCirculum
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(panelSubmission);
            Controls.Add(panelMidTest);
            Controls.Add(panelHoliday);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SemesterCirculum";
            Size = new Size(1157, 741);
            Load += SemesterCirculum_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panelHoliday.ResumeLayout(false);
            panelHoliday.PerformLayout();
            panelSubmission.ResumeLayout(false);
            panelSubmission.PerformLayout();
            panelMidTest.ResumeLayout(false);
            panelMidTest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panelHoliday;
        private Button button4;
        private ComboBox cmbHoliday;
        private Label label4;
        private Panel panelMidTest;
        private Button button5;
        private ComboBox comboBox2;
        private Label label5;
        private Panel panelSubmission;
        private Button button6;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox4;
        private Label label7;
    }
}
