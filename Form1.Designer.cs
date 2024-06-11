namespace AutomatedTimeTable
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lbDate = new Label();
            lbTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            panel12 = new Panel();
            button4 = new Button();
            panel13 = new Panel();
            pictureBox8 = new PictureBox();
            label5 = new Label();
            pictureBox9 = new PictureBox();
            panel14 = new Panel();
            panel9 = new Panel();
            button3 = new Button();
            panel10 = new Panel();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            pictureBox7 = new PictureBox();
            panel11 = new Panel();
            panel7 = new Panel();
            button2 = new Button();
            panel8 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 0);
            panel1.Size = new Size(1924, 77);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(77, 0);
            label6.Name = "label6";
            label6.Size = new Size(1761, 73);
            label6.TabIndex = 2;
            label6.Text = "Automated Time Table Generator";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1838, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 73);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(20, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(lbDate);
            panel2.Controls.Add(lbTime);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1016);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 39);
            panel2.TabIndex = 1;
            // 
            // lbDate
            // 
            lbDate.Dock = DockStyle.Right;
            lbDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDate.ForeColor = Color.White;
            lbDate.Location = new Point(1776, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(148, 39);
            lbDate.TabIndex = 1;
            lbDate.Text = "10/10/2010";
            lbDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTime
            // 
            lbTime.Dock = DockStyle.Left;
            lbTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTime.ForeColor = Color.White;
            lbTime.Location = new Point(0, 0);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(148, 39);
            lbTime.TabIndex = 0;
            lbTime.Text = "10:10:10 AM";
            lbTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(panel12);
            panel3.Controls.Add(panel14);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 77);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(201, 939);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(button4);
            panel12.Controls.Add(panel13);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(5, 353);
            panel12.MaximumSize = new Size(191, 106);
            panel12.MinimumSize = new Size(191, 41);
            panel12.Name = "panel12";
            panel12.Size = new Size(191, 106);
            panel12.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(6, 50);
            button4.Name = "button4";
            button4.Size = new Size(175, 40);
            button4.TabIndex = 1;
            button4.Text = "View Time Table";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.Highlight;
            panel13.Controls.Add(pictureBox8);
            panel13.Controls.Add(label5);
            panel13.Controls.Add(pictureBox9);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(189, 39);
            panel13.TabIndex = 0;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Left;
            pictureBox8.Image = Properties.Resources.arrow_down;
            pictureBox8.Location = new Point(137, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 39);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 2;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 39);
            label5.TabIndex = 1;
            label5.Text = "Student";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Dock = DockStyle.Left;
            pictureBox9.Image = Properties.Resources.clipboard_account;
            pictureBox9.Location = new Point(0, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(44, 39);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(5, 343);
            panel14.Name = "panel14";
            panel14.Size = new Size(187, 10);
            panel14.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(button3);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(5, 237);
            panel9.MaximumSize = new Size(191, 106);
            panel9.MinimumSize = new Size(191, 41);
            panel9.Name = "panel9";
            panel9.Size = new Size(191, 106);
            panel9.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(6, 50);
            button3.Name = "button3";
            button3.Size = new Size(175, 40);
            button3.TabIndex = 1;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Highlight;
            panel10.Controls.Add(pictureBox6);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(pictureBox7);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(189, 39);
            panel10.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Left;
            pictureBox6.Image = Properties.Resources.arrow_down;
            pictureBox6.Location = new Point(137, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(44, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 39);
            label4.TabIndex = 1;
            label4.Text = "Teacher";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Left;
            pictureBox7.Image = Properties.Resources.account_star;
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(44, 39);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(5, 227);
            panel11.Name = "panel11";
            panel11.Size = new Size(187, 10);
            panel11.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(button2);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(5, 121);
            panel7.MaximumSize = new Size(191, 106);
            panel7.MinimumSize = new Size(191, 41);
            panel7.Name = "panel7";
            panel7.Size = new Size(191, 106);
            panel7.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(6, 50);
            button2.Name = "button2";
            button2.Size = new Size(175, 40);
            button2.TabIndex = 1;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Highlight;
            panel8.Controls.Add(pictureBox4);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(pictureBox5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(189, 39);
            panel8.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = Properties.Resources.arrow_down;
            pictureBox4.Location = new Point(137, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 39);
            label3.TabIndex = 1;
            label3.Text = "HOD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Left;
            pictureBox5.Image = Properties.Resources.account_tie;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(5, 111);
            panel6.Name = "panel6";
            panel6.Size = new Size(187, 10);
            panel6.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(5, 5);
            panel4.MaximumSize = new Size(191, 106);
            panel4.MinimumSize = new Size(191, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 106);
            panel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(6, 50);
            button1.Name = "button1";
            button1.Size = new Size(175, 40);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(189, 39);
            panel5.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.arrow_down;
            pictureBox3.Location = new Point(137, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 39);
            label2.TabIndex = 1;
            label2.Text = "Admin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.admin;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.BorderStyle = BorderStyle.Fixed3D;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(201, 77);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1723, 939);
            panelContainer.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panelContainer);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lbDate;
        private Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button button1;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Button button2;
        private Panel panel8;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox5;
        private Panel panel6;
        private Panel panel9;
        private Button button3;
        private Panel panel10;
        private PictureBox pictureBox6;
        private Label label4;
        private PictureBox pictureBox7;
        private Panel panel11;
        private Panel panel12;
        private Button button4;
        private Panel panel13;
        private PictureBox pictureBox8;
        private Label label5;
        private PictureBox pictureBox9;
        private Panel panel14;
        private Label label6;
        private Panel panelContainer;
    }
}