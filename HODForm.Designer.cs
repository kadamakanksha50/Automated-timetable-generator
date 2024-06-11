namespace AutomatedTimeTable
{
    partial class HODForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            lbDepartment = new Label();
            panel2 = new Panel();
            lbLoginTime = new Label();
            lbWelcome = new Label();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            lbCurrentTime = new Label();
            lbInstructions = new Label();
            lbNote = new Label();
            panelContainer = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbDepartment);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 64);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1806, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 64);
            label2.TabIndex = 1;
            label2.Text = "Logout";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // lbDepartment
            // 
            lbDepartment.Dock = DockStyle.Left;
            lbDepartment.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDepartment.ForeColor = Color.White;
            lbDepartment.Location = new Point(0, 0);
            lbDepartment.Name = "lbDepartment";
            lbDepartment.Size = new Size(347, 64);
            lbDepartment.TabIndex = 0;
            lbDepartment.Text = "Head Of Department";
            lbDepartment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbLoginTime);
            panel2.Controls.Add(lbWelcome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8, 0, 8, 0);
            panel2.Size = new Size(1924, 46);
            panel2.TabIndex = 1;
            // 
            // lbLoginTime
            // 
            lbLoginTime.Dock = DockStyle.Right;
            lbLoginTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbLoginTime.Location = new Point(1629, 0);
            lbLoginTime.Name = "lbLoginTime";
            lbLoginTime.Size = new Size(285, 44);
            lbLoginTime.TabIndex = 1;
            lbLoginTime.Text = "Login time : 19:20:35";
            lbLoginTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbWelcome
            // 
            lbWelcome.Dock = DockStyle.Left;
            lbWelcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbWelcome.Location = new Point(8, 0);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(285, 44);
            lbWelcome.TabIndex = 0;
            lbWelcome.Text = "Welcome, K.S. Pawar Sir";
            lbWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 80);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.BlueViolet;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(939, 17);
            button5.Name = "button5";
            button5.Size = new Size(212, 50);
            button5.TabIndex = 11;
            button5.Text = "Create Time Table";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumVioletRed;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(774, 17);
            button4.Name = "button4";
            button4.Size = new Size(159, 50);
            button4.TabIndex = 10;
            button4.Text = "Add Subjects";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(546, 17);
            button3.Name = "button3";
            button3.Size = new Size(222, 50);
            button3.TabIndex = 9;
            button3.Text = "Add Semester Circulum";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(282, 17);
            button2.Name = "button2";
            button2.Size = new Size(258, 50);
            button2.TabIndex = 8;
            button2.Text = "View Department Teachers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(18, 17);
            button1.Name = "button1";
            button1.Size = new Size(258, 50);
            button1.TabIndex = 7;
            button1.Text = "View Department Classes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(lbCurrentTime);
            panel4.Controls.Add(lbInstructions);
            panel4.Controls.Add(lbNote);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 1005);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 0, 10, 0);
            panel4.Size = new Size(1924, 50);
            panel4.TabIndex = 3;
            // 
            // lbCurrentTime
            // 
            lbCurrentTime.Dock = DockStyle.Right;
            lbCurrentTime.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCurrentTime.ForeColor = Color.Black;
            lbCurrentTime.Location = new Point(1775, 0);
            lbCurrentTime.Name = "lbCurrentTime";
            lbCurrentTime.Size = new Size(139, 50);
            lbCurrentTime.TabIndex = 2;
            lbCurrentTime.Text = "10:10:10 AM";
            lbCurrentTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbInstructions
            // 
            lbInstructions.Dock = DockStyle.Left;
            lbInstructions.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbInstructions.ForeColor = Color.Black;
            lbInstructions.Location = new Point(129, 0);
            lbInstructions.Name = "lbInstructions";
            lbInstructions.Size = new Size(928, 50);
            lbInstructions.TabIndex = 1;
            lbInstructions.Text = "Instruction :";
            lbInstructions.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNote
            // 
            lbNote.Dock = DockStyle.Left;
            lbNote.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbNote.ForeColor = Color.Red;
            lbNote.Location = new Point(10, 0);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(119, 50);
            lbNote.TabIndex = 0;
            lbNote.Text = "Instruction :";
            lbNote.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 190);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1924, 815);
            panelContainer.TabIndex = 4;
            panelContainer.ControlRemoved += panelContainer_ControlRemoved;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // HODForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panelContainer);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "HODForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HODForm";
            WindowState = FormWindowState.Maximized;
            Load += HODForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lbDepartment;
        private Panel panel2;
        private Label lbLoginTime;
        private Label lbWelcome;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Label lbNote;
        private System.Windows.Forms.Timer timer1;
        private Label lbCurrentTime;
        private Label lbInstructions;
        public Panel panelContainer;
    }
}