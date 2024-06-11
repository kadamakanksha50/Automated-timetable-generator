namespace AutomatedTimeTable
{
    partial class StudentPanel
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            gridTimeTableList = new DataGridView();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            button1 = new Button();
            cmbClassName = new ComboBox();
            label5 = new Label();
            cmbDepartment = new ComboBox();
            label4 = new Label();
            cmbSemesterName = new ComboBox();
            label3 = new Label();
            cmbYear = new ComboBox();
            label2 = new Label();
            day = new DataGridViewTextBoxColumn();
            first = new DataGridViewTextBoxColumn();
            second = new DataGridViewTextBoxColumn();
            third = new DataGridViewTextBoxColumn();
            fourth = new DataGridViewTextBoxColumn();
            fifth = new DataGridViewTextBoxColumn();
            sixth = new DataGridViewTextBoxColumn();
            seventh = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTimeTableList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1603, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(1603, 56);
            label1.TabIndex = 0;
            label1.Text = "Student Section";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 955);
            panel2.Name = "panel2";
            panel2.Size = new Size(1603, 38);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(gridTimeTableList);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30, 10, 30, 10);
            panel3.Size = new Size(1603, 899);
            panel3.TabIndex = 2;
            // 
            // gridTimeTableList
            // 
            gridTimeTableList.AllowUserToAddRows = false;
            gridTimeTableList.AllowUserToDeleteRows = false;
            gridTimeTableList.BackgroundColor = Color.White;
            gridTimeTableList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridTimeTableList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridTimeTableList.ColumnHeadersHeight = 60;
            gridTimeTableList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridTimeTableList.Columns.AddRange(new DataGridViewColumn[] { day, first, second, third, fourth, fifth, sixth, seventh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridTimeTableList.DefaultCellStyle = dataGridViewCellStyle2;
            gridTimeTableList.Dock = DockStyle.Top;
            gridTimeTableList.GridColor = Color.White;
            gridTimeTableList.Location = new Point(30, 178);
            gridTimeTableList.Name = "gridTimeTableList";
            gridTimeTableList.ReadOnly = true;
            gridTimeTableList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gridTimeTableList.RowHeadersVisible = false;
            gridTimeTableList.RowHeadersWidth = 51;
            gridTimeTableList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridTimeTableList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            gridTimeTableList.RowTemplate.Height = 70;
            gridTimeTableList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridTimeTableList.Size = new Size(1543, 676);
            gridTimeTableList.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(30, 162);
            panel4.Name = "panel4";
            panel4.Size = new Size(1543, 16);
            panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbClassName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbDepartment);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbSemesterName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 10);
            groupBox1.Margin = new Padding(3, 3, 3, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1543, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Academic Year";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1301, 78);
            button1.Name = "button1";
            button1.Size = new Size(198, 58);
            button1.TabIndex = 8;
            button1.Text = "View Time Table";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbClassName
            // 
            cmbClassName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClassName.FlatStyle = FlatStyle.System;
            cmbClassName.FormattingEnabled = true;
            cmbClassName.Location = new Point(844, 86);
            cmbClassName.Name = "cmbClassName";
            cmbClassName.Size = new Size(284, 33);
            cmbClassName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(716, 87);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 6;
            label5.Text = "Class Name :";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FlatStyle = FlatStyle.System;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "SELECT", "CSE", "AIDS", "EEE", "ECE" });
            cmbDepartment.Location = new Point(844, 30);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(284, 33);
            cmbDepartment.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(709, 32);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 4;
            label4.Text = "Department :";
            // 
            // cmbSemesterName
            // 
            cmbSemesterName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemesterName.FlatStyle = FlatStyle.System;
            cmbSemesterName.FormattingEnabled = true;
            cmbSemesterName.Location = new Point(368, 87);
            cmbSemesterName.Name = "cmbSemesterName";
            cmbSemesterName.Size = new Size(284, 33);
            cmbSemesterName.TabIndex = 3;
            cmbSemesterName.SelectedIndexChanged += cmbSemesterName_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 88);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 2;
            label3.Text = "Semester Name :";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FlatStyle = FlatStyle.System;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(368, 32);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(284, 33);
            cmbYear.TabIndex = 1;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 33);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 0;
            label2.Text = "Academic Year :";
            // 
            // day
            // 
            day.HeaderText = "Day/Time";
            day.MinimumWidth = 6;
            day.Name = "day";
            day.ReadOnly = true;
            day.Width = 125;
            // 
            // first
            // 
            first.HeaderText = "10:00 to 10:50";
            first.MinimumWidth = 6;
            first.Name = "first";
            first.ReadOnly = true;
            first.Width = 220;
            // 
            // second
            // 
            second.HeaderText = "10:50 to 11:40";
            second.MinimumWidth = 6;
            second.Name = "second";
            second.ReadOnly = true;
            second.Width = 250;
            // 
            // third
            // 
            third.HeaderText = "11:40 to 12:20";
            third.MinimumWidth = 6;
            third.Name = "third";
            third.ReadOnly = true;
            third.Width = 250;
            // 
            // fourth
            // 
            fourth.HeaderText = "12:20 to 01:10";
            fourth.MinimumWidth = 6;
            fourth.Name = "fourth";
            fourth.ReadOnly = true;
            fourth.Width = 200;
            // 
            // fifth
            // 
            fifth.HeaderText = "01:10 to 02:00";
            fifth.MinimumWidth = 6;
            fifth.Name = "fifth";
            fifth.ReadOnly = true;
            fifth.Width = 200;
            // 
            // sixth
            // 
            sixth.HeaderText = "02:00 to 02:50";
            sixth.MinimumWidth = 6;
            sixth.Name = "sixth";
            sixth.ReadOnly = true;
            sixth.Width = 220;
            // 
            // seventh
            // 
            seventh.HeaderText = "02:50 to 04:50";
            seventh.MinimumWidth = 6;
            seventh.Name = "seventh";
            seventh.ReadOnly = true;
            seventh.Width = 250;
            // 
            // StudentPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "StudentPanel";
            Size = new Size(1603, 993);
            Load += StudentPanel_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTimeTableList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private ComboBox cmbDepartment;
        private Label label4;
        private ComboBox cmbSemesterName;
        private Label label3;
        private ComboBox cmbYear;
        private Label label2;
        private ComboBox cmbClassName;
        private Label label5;
        private DataGridView gridTimeTableList;
        private Panel panel4;
        private Button button1;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn first;
        private DataGridViewTextBoxColumn second;
        private DataGridViewTextBoxColumn third;
        private DataGridViewTextBoxColumn fourth;
        private DataGridViewTextBoxColumn fifth;
        private DataGridViewTextBoxColumn sixth;
        private DataGridViewTextBoxColumn seventh;
    }
}
