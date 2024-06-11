namespace AutomatedTimeTable
{
    partial class TeacherForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            lbWelcome = new Label();
            panel2 = new Panel();
            lbTime = new Label();
            lbLoginTime = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            gridTimetableList = new DataGridView();
            Day = new DataGridViewTextBoxColumn();
            first = new DataGridViewTextBoxColumn();
            second = new DataGridViewTextBoxColumn();
            third = new DataGridViewTextBoxColumn();
            fourth = new DataGridViewTextBoxColumn();
            fifth = new DataGridViewTextBoxColumn();
            sixth = new DataGridViewTextBoxColumn();
            seventh = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lbDepartment = new Label();
            cmbYear = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTimetableList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(lbWelcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 65);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.Dock = DockStyle.Right;
            linkLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(1804, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 63);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lbWelcome
            // 
            lbWelcome.Dock = DockStyle.Left;
            lbWelcome.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbWelcome.Location = new Point(0, 0);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(473, 63);
            lbWelcome.TabIndex = 0;
            lbWelcome.Text = "Welcome, A.B. Teacher Mam | Department";
            lbWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(lbTime);
            panel2.Controls.Add(lbLoginTime);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1009);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 46);
            panel2.TabIndex = 1;
            // 
            // lbTime
            // 
            lbTime.Dock = DockStyle.Right;
            lbTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTime.Location = new Point(1781, 0);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(143, 46);
            lbTime.TabIndex = 2;
            lbTime.Text = "10:10:10 AM";
            lbTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbLoginTime
            // 
            lbLoginTime.Dock = DockStyle.Left;
            lbLoginTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbLoginTime.Location = new Point(143, 0);
            lbLoginTime.Name = "lbLoginTime";
            lbLoginTime.Size = new Size(125, 46);
            lbLoginTime.TabIndex = 1;
            lbLoginTime.Text = "10:10:10 AM";
            lbLoginTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 46);
            label2.TabIndex = 0;
            label2.Text = "Login Time :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // gridTimetableList
            // 
            gridTimetableList.AllowUserToAddRows = false;
            gridTimetableList.AllowUserToDeleteRows = false;
            gridTimetableList.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridTimetableList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridTimetableList.ColumnHeadersHeight = 60;
            gridTimetableList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridTimetableList.Columns.AddRange(new DataGridViewColumn[] { Day, first, second, third, fourth, fifth, sixth, seventh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridTimetableList.DefaultCellStyle = dataGridViewCellStyle2;
            gridTimetableList.GridColor = SystemColors.ButtonFace;
            gridTimetableList.Location = new Point(120, 289);
            gridTimetableList.Name = "gridTimetableList";
            gridTimetableList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridTimetableList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridTimetableList.RowHeadersVisible = false;
            gridTimetableList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            gridTimetableList.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridTimetableList.RowTemplate.Height = 70;
            gridTimetableList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridTimetableList.Size = new Size(1684, 642);
            gridTimetableList.TabIndex = 2;
            // 
            // Day
            // 
            Day.HeaderText = "Day/Time";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            Day.ReadOnly = true;
            Day.Width = 125;
            // 
            // first
            // 
            first.HeaderText = "09:30 to 10:30 ";
            first.MinimumWidth = 6;
            first.Name = "first";
            first.ReadOnly = true;
            first.Width = 200;
            // 
            // second
            // 
            second.HeaderText = "10:30 to 11:30";
            second.MinimumWidth = 6;
            second.Name = "second";
            second.ReadOnly = true;
            second.Width = 200;
            // 
            // third
            // 
            third.HeaderText = "11:30 to 12:30";
            third.MinimumWidth = 6;
            third.Name = "third";
            third.ReadOnly = true;
            third.Width = 200;
            // 
            // fourth
            // 
            fourth.HeaderText = "12:30 to 01:30";
            fourth.MinimumWidth = 6;
            fourth.Name = "fourth";
            fourth.ReadOnly = true;
            fourth.Width = 200;
            // 
            // fifth
            // 
            fifth.HeaderText = "01:30 to 02:30";
            fifth.MinimumWidth = 6;
            fifth.Name = "fifth";
            fifth.ReadOnly = true;
            fifth.Width = 200;
            // 
            // sixth
            // 
            sixth.HeaderText = "02:30 to 03:30";
            sixth.MinimumWidth = 6;
            sixth.Name = "sixth";
            sixth.ReadOnly = true;
            sixth.Width = 299;
            // 
            // seventh
            // 
            seventh.HeaderText = "03:30 to 05:30";
            seventh.MinimumWidth = 6;
            seventh.Name = "seventh";
            seventh.ReadOnly = true;
            seventh.Width = 250;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbDepartment);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(597, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Academic Filter";
            // 
            // lbDepartment
            // 
            lbDepartment.AutoSize = true;
            lbDepartment.BackColor = Color.Yellow;
            lbDepartment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDepartment.Location = new Point(510, 56);
            lbDepartment.Name = "lbDepartment";
            lbDepartment.Size = new Size(122, 28);
            lbDepartment.TabIndex = 2;
            lbDepartment.Text = "Department";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FlatStyle = FlatStyle.System;
            cmbYear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(182, 54);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(307, 36);
            cmbYear.TabIndex = 1;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 56);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 0;
            label1.Text = "Academic Year :";
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox1);
            Controls.Add(gridTimetableList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "TeacherForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherForm";
            WindowState = FormWindowState.Maximized;
            Load += TeacherForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTimetableList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label lbWelcome;
        private Panel panel2;
        private Label label2;
        private Label lbTime;
        private Label lbLoginTime;
        private System.Windows.Forms.Timer timer1;
        private DataGridView gridTimetableList;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn first;
        private DataGridViewTextBoxColumn second;
        private DataGridViewTextBoxColumn third;
        private DataGridViewTextBoxColumn fourth;
        private DataGridViewTextBoxColumn fifth;
        private DataGridViewTextBoxColumn sixth;
        private DataGridViewTextBoxColumn seventh;
        private GroupBox groupBox1;
        private Label lbDepartment;
        private ComboBox cmbYear;
        private Label label1;
    }
}