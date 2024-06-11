namespace AutomatedTimeTable
{
    partial class TimeTable
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            button1 = new Button();
            cmbClassName = new ComboBox();
            label6 = new Label();
            cmbSemesterName = new ComboBox();
            label5 = new Label();
            lbDepartment = new Label();
            label4 = new Label();
            cmbYear = new ComboBox();
            label3 = new Label();
            gridTimetableList = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            DayTime = new DataGridViewTextBoxColumn();
            first = new DataGridViewTextBoxColumn();
            second = new DataGridViewTextBoxColumn();
            third = new DataGridViewTextBoxColumn();
            fourth = new DataGridViewTextBoxColumn();
            fifth = new DataGridViewTextBoxColumn();
            sixth = new DataGridViewTextBoxColumn();
            seventh = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTimetableList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1567, 63);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1507, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 63);
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
            label1.Size = new Size(232, 63);
            label1.TabIndex = 0;
            label1.Text = "Create Time Table";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 746);
            panel2.Name = "panel2";
            panel2.Size = new Size(1567, 37);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(479, 683);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbClassName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbSemesterName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbDepartment);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 459);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Class Details";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 384);
            button1.Name = "button1";
            button1.Size = new Size(385, 54);
            button1.TabIndex = 8;
            button1.Text = "Generate Time Table";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbClassName
            // 
            cmbClassName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClassName.FlatStyle = FlatStyle.System;
            cmbClassName.FormattingEnabled = true;
            cmbClassName.Location = new Point(34, 317);
            cmbClassName.Name = "cmbClassName";
            cmbClassName.Size = new Size(386, 36);
            cmbClassName.TabIndex = 7;
            cmbClassName.SelectedIndexChanged += cmbClassName_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 285);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 6;
            label6.Text = "Class Name";
            // 
            // cmbSemesterName
            // 
            cmbSemesterName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemesterName.FlatStyle = FlatStyle.System;
            cmbSemesterName.FormattingEnabled = true;
            cmbSemesterName.Location = new Point(34, 241);
            cmbSemesterName.Name = "cmbSemesterName";
            cmbSemesterName.Size = new Size(386, 36);
            cmbSemesterName.TabIndex = 5;
            cmbSemesterName.SelectedIndexChanged += cmbSemesterName_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 209);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 4;
            label5.Text = "Semester Name";
            // 
            // lbDepartment
            // 
            lbDepartment.AutoSize = true;
            lbDepartment.BackColor = Color.Yellow;
            lbDepartment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDepartment.Location = new Point(28, 169);
            lbDepartment.Name = "lbDepartment";
            lbDepartment.Size = new Size(114, 25);
            lbDepartment.TabIndex = 2;
            lbDepartment.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 131);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FlatStyle = FlatStyle.System;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(34, 84);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(386, 36);
            cmbYear.TabIndex = 1;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 52);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 0;
            label3.Text = "Academic Year";
            // 
            // gridTimetableList
            // 
            gridTimetableList.AllowUserToAddRows = false;
            gridTimetableList.AllowUserToDeleteRows = false;
            gridTimetableList.AllowUserToResizeRows = false;
            gridTimetableList.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridTimetableList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridTimetableList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTimetableList.Columns.AddRange(new DataGridViewColumn[] { DayTime, first, second, third, fourth, fifth, sixth, seventh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridTimetableList.DefaultCellStyle = dataGridViewCellStyle2;
            gridTimetableList.Dock = DockStyle.Fill;
            gridTimetableList.Location = new Point(479, 63);
            gridTimetableList.Name = "gridTimetableList";
            gridTimetableList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridTimetableList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridTimetableList.RowHeadersVisible = false;
            gridTimetableList.RowHeadersWidth = 200;
            gridTimetableList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridTimetableList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            gridTimetableList.RowTemplate.Height = 70;
            gridTimetableList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTimetableList.Size = new Size(1088, 683);
            gridTimetableList.TabIndex = 3;
            gridTimetableList.CellContentClick += gridTimetableList_CellContentClick;
            gridTimetableList.CellFormatting += gridTimetableList_CellFormatting;
            gridTimetableList.CellPainting += gridTimetableList_CellPainting;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // DayTime
            // 
            DayTime.Frozen = true;
            DayTime.HeaderText = "Day/Time";
            DayTime.MinimumWidth = 6;
            DayTime.Name = "DayTime";
            DayTime.ReadOnly = true;
            DayTime.Width = 125;
            // 
            // first
            // 
            first.Frozen = true;
            first.HeaderText = "10:00 to 10:50";
            first.MinimumWidth = 6;
            first.Name = "first";
            first.ReadOnly = true;
            first.Width = 125;
            // 
            // second
            // 
            second.HeaderText = "10:50 to 11:40";
            second.MinimumWidth = 6;
            second.Name = "second";
            second.ReadOnly = true;
            second.Width = 125;
            // 
            // third
            // 
            third.HeaderText = "11:40 to 12:20";
            third.MinimumWidth = 6;
            third.Name = "third";
            third.ReadOnly = true;
            third.Width = 125;
            // 
            // fourth
            // 
            fourth.HeaderText = "12:20 to 01:10";
            fourth.MinimumWidth = 6;
            fourth.Name = "fourth";
            fourth.ReadOnly = true;
            fourth.Width = 125;
            // 
            // fifth
            // 
            fifth.HeaderText = "01:10 to 02:00";
            fifth.MinimumWidth = 6;
            fifth.Name = "fifth";
            fifth.ReadOnly = true;
            fifth.Width = 125;
            // 
            // sixth
            // 
            sixth.HeaderText = "02:00 to 02:50";
            sixth.MinimumWidth = 6;
            sixth.Name = "sixth";
            sixth.ReadOnly = true;
            sixth.Width = 125;
            // 
            // seventh
            // 
            seventh.HeaderText = "02:50 to 04:50";
            seventh.MinimumWidth = 6;
            seventh.Name = "seventh";
            seventh.ReadOnly = true;
            seventh.Width = 200;
            // 
            // TimeTable
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(gridTimetableList);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TimeTable";
            Size = new Size(1567, 783);
            Load += TimeTable_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridTimetableList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView gridTimetableList;
        private GroupBox groupBox1;
        private ComboBox cmbYear;
        private Label label3;
        private Label label4;
        private Button button1;
        private ComboBox cmbClassName;
        private Label label6;
        private ComboBox cmbSemesterName;
        private Label label5;
        private Label lbDepartment;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn DayTime;
        private DataGridViewTextBoxColumn first;
        private DataGridViewTextBoxColumn second;
        private DataGridViewTextBoxColumn third;
        private DataGridViewTextBoxColumn fourth;
        private DataGridViewTextBoxColumn fifth;
        private DataGridViewTextBoxColumn sixth;
        private DataGridViewTextBoxColumn seventh;
    }
}
