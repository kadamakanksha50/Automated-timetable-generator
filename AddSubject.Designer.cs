namespace AutomatedTimeTable
{
    partial class AddSubject
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            btnNew = new Button();
            panel3 = new Panel();
            gridSubjectList = new DataGridView();
            panel6 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            btnCacnelSub = new Button();
            btnAddSub = new Button();
            txtHours = new TextBox();
            label13 = new Label();
            cmbTeacher = new ComboBox();
            label12 = new Label();
            cmbType = new ComboBox();
            label11 = new Label();
            txtName = new TextBox();
            label10 = new Label();
            txtCode = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            cmbClass = new ComboBox();
            label8 = new Label();
            lbDepartment = new Label();
            label6 = new Label();
            cmbSemester = new ComboBox();
            label5 = new Label();
            cmbYear = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            gridClassSubjectList = new DataGridView();
            SrNo = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            SubjectCode = new DataGridViewTextBoxColumn();
            SubjectType = new DataGridViewTextBoxColumn();
            TeacherAssign = new DataGridViewTextBoxColumn();
            NoOfHours = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewLinkColumn();
            Action2 = new DataGridViewLinkColumn();
            label7 = new Label();
            lbDurationLeft = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSubjectList).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClassSubjectList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1460, 57);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1406, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 57);
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
            label1.Size = new Size(217, 57);
            label1.TabIndex = 0;
            label1.Text = "Add Subjects ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnNew);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1460, 59);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Teal;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1269, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumVioletRed;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1147, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.HotTrack;
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(1025, 9);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(116, 40);
            btnNew.TabIndex = 0;
            btnNew.Text = "Add New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(gridSubjectList);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 558);
            panel3.Name = "panel3";
            panel3.Size = new Size(1460, 227);
            panel3.TabIndex = 2;
            // 
            // gridSubjectList
            // 
            gridSubjectList.AllowUserToAddRows = false;
            gridSubjectList.AllowUserToDeleteRows = false;
            gridSubjectList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSubjectList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridSubjectList.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridSubjectList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridSubjectList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridSubjectList.DefaultCellStyle = dataGridViewCellStyle2;
            gridSubjectList.Dock = DockStyle.Fill;
            gridSubjectList.GridColor = SystemColors.ButtonHighlight;
            gridSubjectList.Location = new Point(0, 49);
            gridSubjectList.Name = "gridSubjectList";
            gridSubjectList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridSubjectList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridSubjectList.RowHeadersVisible = false;
            gridSubjectList.RowHeadersWidth = 51;
            gridSubjectList.RowTemplate.Height = 29;
            gridSubjectList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSubjectList.Size = new Size(1458, 176);
            gridSubjectList.TabIndex = 1;
            gridSubjectList.CellContentClick += gridSubjectList_CellContentClick;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1458, 49);
            panel6.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1458, 49);
            label3.TabIndex = 0;
            label3.Text = "Subject List(s)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(groupBox2);
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 116);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15);
            panel4.Size = new Size(624, 442);
            panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCacnelSub);
            groupBox2.Controls.Add(btnAddSub);
            groupBox2.Controls.Add(txtHours);
            groupBox2.Controls.Add(lbDurationLeft);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cmbTeacher);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(cmbType);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtCode);
            groupBox2.Controls.Add(label9);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(15, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(592, 250);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Subject Details";
            // 
            // btnCacnelSub
            // 
            btnCacnelSub.BackColor = Color.Crimson;
            btnCacnelSub.Cursor = Cursors.Hand;
            btnCacnelSub.FlatStyle = FlatStyle.Flat;
            btnCacnelSub.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCacnelSub.ForeColor = Color.White;
            btnCacnelSub.Location = new Point(299, 192);
            btnCacnelSub.Name = "btnCacnelSub";
            btnCacnelSub.Size = new Size(240, 47);
            btnCacnelSub.TabIndex = 24;
            btnCacnelSub.Text = "Cancel";
            btnCacnelSub.UseVisualStyleBackColor = false;
            btnCacnelSub.Click += btnCacnelSub_Click;
            // 
            // btnAddSub
            // 
            btnAddSub.BackColor = SystemColors.HotTrack;
            btnAddSub.Cursor = Cursors.Hand;
            btnAddSub.FlatStyle = FlatStyle.Flat;
            btnAddSub.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSub.ForeColor = Color.White;
            btnAddSub.Location = new Point(53, 192);
            btnAddSub.Name = "btnAddSub";
            btnAddSub.Size = new Size(240, 47);
            btnAddSub.TabIndex = 23;
            btnAddSub.Text = "Add Subject";
            btnAddSub.UseVisualStyleBackColor = false;
            btnAddSub.Click += btnAddSub_Click;
            // 
            // txtHours
            // 
            txtHours.BackColor = SystemColors.Window;
            txtHours.BorderStyle = BorderStyle.FixedSingle;
            txtHours.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtHours.Location = new Point(118, 142);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(136, 31);
            txtHours.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(20, 144);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 21;
            label13.Text = "Duration :";
            // 
            // cmbTeacher
            // 
            cmbTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTeacher.FlatStyle = FlatStyle.System;
            cmbTeacher.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTeacher.FormattingEnabled = true;
            cmbTeacher.Location = new Point(359, 88);
            cmbTeacher.Name = "cmbTeacher";
            cmbTeacher.Size = new Size(212, 33);
            cmbTeacher.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(270, 91);
            label12.Name = "label12";
            label12.Size = new Size(83, 25);
            label12.TabIndex = 19;
            label12.Text = "Teacher :";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FlatStyle = FlatStyle.System;
            cmbType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "SELECT", "Theory", "Lab" });
            cmbType.Location = new Point(118, 89);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(136, 33);
            cmbType.TabIndex = 18;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(55, 90);
            label11.Name = "label11";
            label11.Size = new Size(60, 25);
            label11.TabIndex = 17;
            label11.Text = "Type :";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.CharacterCasing = CharacterCasing.Upper;
            txtName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(359, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 31);
            txtName.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(283, 41);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 15;
            label10.Text = "Name :";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.Yellow;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.CharacterCasing = CharacterCasing.Upper;
            txtCode.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtCode.Location = new Point(118, 41);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(136, 31);
            txtCode.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(51, 41);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 13;
            label9.Text = "Code :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbClass);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lbDepartment);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbSemester);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbYear);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Class Details";
            // 
            // cmbClass
            // 
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.FlatStyle = FlatStyle.System;
            cmbClass.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(385, 98);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(188, 33);
            cmbClass.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(317, 101);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 14;
            label8.Text = "Class :";
            // 
            // lbDepartment
            // 
            lbDepartment.AutoSize = true;
            lbDepartment.BackColor = Color.Yellow;
            lbDepartment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDepartment.Location = new Point(450, 53);
            lbDepartment.Name = "lbDepartment";
            lbDepartment.Size = new Size(123, 25);
            lbDepartment.TabIndex = 13;
            lbDepartment.Text = "Department :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(317, 53);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 12;
            label6.Text = "Department :";
            // 
            // cmbSemester
            // 
            cmbSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemester.FlatStyle = FlatStyle.System;
            cmbSemester.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Location = new Point(118, 98);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(188, 33);
            cmbSemester.TabIndex = 11;
            cmbSemester.SelectedIndexChanged += cmbSemester_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 101);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 10;
            label5.Text = "Semester :";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FlatStyle = FlatStyle.System;
            cmbYear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(118, 50);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(188, 33);
            cmbYear.TabIndex = 9;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 53);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 8;
            label4.Text = "A. Year :";
            // 
            // panel5
            // 
            panel5.Controls.Add(gridClassSubjectList);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(624, 116);
            panel5.Name = "panel5";
            panel5.Size = new Size(836, 442);
            panel5.TabIndex = 4;
            // 
            // gridClassSubjectList
            // 
            gridClassSubjectList.AllowUserToAddRows = false;
            gridClassSubjectList.AllowUserToDeleteRows = false;
            gridClassSubjectList.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridClassSubjectList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridClassSubjectList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClassSubjectList.Columns.AddRange(new DataGridViewColumn[] { SrNo, SubjectName, SubjectCode, SubjectType, TeacherAssign, NoOfHours, Actions, Action2 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            gridClassSubjectList.DefaultCellStyle = dataGridViewCellStyle7;
            gridClassSubjectList.Dock = DockStyle.Fill;
            gridClassSubjectList.Location = new Point(0, 0);
            gridClassSubjectList.Name = "gridClassSubjectList";
            gridClassSubjectList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            gridClassSubjectList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            gridClassSubjectList.RowHeadersVisible = false;
            gridClassSubjectList.RowHeadersWidth = 51;
            gridClassSubjectList.RowTemplate.Height = 29;
            gridClassSubjectList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClassSubjectList.Size = new Size(836, 442);
            gridClassSubjectList.TabIndex = 0;
            gridClassSubjectList.CellContentClick += gridClassSubjectList_CellContentClick;
            // 
            // SrNo
            // 
            SrNo.Frozen = true;
            SrNo.HeaderText = "#";
            SrNo.MinimumWidth = 6;
            SrNo.Name = "SrNo";
            SrNo.ReadOnly = true;
            SrNo.Width = 35;
            // 
            // SubjectName
            // 
            SubjectName.Frozen = true;
            SubjectName.HeaderText = "Subject Name";
            SubjectName.MinimumWidth = 6;
            SubjectName.Name = "SubjectName";
            SubjectName.ReadOnly = true;
            SubjectName.Width = 180;
            // 
            // SubjectCode
            // 
            SubjectCode.HeaderText = "Subject Code";
            SubjectCode.MinimumWidth = 6;
            SubjectCode.Name = "SubjectCode";
            SubjectCode.ReadOnly = true;
            SubjectCode.Width = 140;
            // 
            // SubjectType
            // 
            SubjectType.HeaderText = "Subject Type";
            SubjectType.MinimumWidth = 6;
            SubjectType.Name = "SubjectType";
            SubjectType.ReadOnly = true;
            SubjectType.Width = 160;
            // 
            // TeacherAssign
            // 
            TeacherAssign.HeaderText = "Teacher Assign";
            TeacherAssign.MinimumWidth = 6;
            TeacherAssign.Name = "TeacherAssign";
            TeacherAssign.ReadOnly = true;
            TeacherAssign.Width = 180;
            // 
            // NoOfHours
            // 
            NoOfHours.HeaderText = "No Of Hours";
            NoOfHours.MinimumWidth = 6;
            NoOfHours.Name = "NoOfHours";
            NoOfHours.ReadOnly = true;
            NoOfHours.Width = 137;
            // 
            // Actions
            // 
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            Actions.DefaultCellStyle = dataGridViewCellStyle5;
            Actions.HeaderText = "";
            Actions.LinkBehavior = LinkBehavior.NeverUnderline;
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.VisitedLinkColor = Color.Blue;
            Actions.Width = 60;
            // 
            // Action2
            // 
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            Action2.DefaultCellStyle = dataGridViewCellStyle6;
            Action2.HeaderText = "";
            Action2.LinkBehavior = LinkBehavior.NeverUnderline;
            Action2.MinimumWidth = 6;
            Action2.Name = "Action2";
            Action2.ReadOnly = true;
            Action2.VisitedLinkColor = Color.Blue;
            Action2.Width = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(258, 144);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 21;
            label7.Text = "Duration :";
            // 
            // lbDurationLeft
            // 
            lbDurationLeft.AutoSize = true;
            lbDurationLeft.BackColor = Color.Yellow;
            lbDurationLeft.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDurationLeft.Location = new Point(359, 144);
            lbDurationLeft.Name = "lbDurationLeft";
            lbDurationLeft.Size = new Size(95, 25);
            lbDurationLeft.TabIndex = 21;
            lbDurationLeft.Text = "Duration :";
            // 
            // AddSubject
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddSubject";
            Size = new Size(1460, 785);
            Load += AddSubject_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSubjectList).EndInit();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClassSubjectList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button btnCancel;
        private Button btnSave;
        private Button btnNew;
        private DataGridView gridClassSubjectList;
        private DataGridView gridSubjectList;
        private Panel panel6;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cmbType;
        private Label label11;
        private TextBox txtName;
        private Label label10;
        private TextBox txtCode;
        private Label label9;
        private ComboBox cmbClass;
        private Label label8;
        private Label lbDepartment;
        private Label label6;
        private ComboBox cmbSemester;
        private Label label5;
        private ComboBox cmbYear;
        private Label label4;
        private Button btnCacnelSub;
        private Button btnAddSub;
        private TextBox txtHours;
        private Label label13;
        private ComboBox cmbTeacher;
        private Label label12;
        private DataGridViewTextBoxColumn SrNo;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn SubjectCode;
        private DataGridViewTextBoxColumn SubjectType;
        private DataGridViewTextBoxColumn TeacherAssign;
        private DataGridViewTextBoxColumn NoOfHours;
        private DataGridViewLinkColumn Actions;
        private DataGridViewLinkColumn Action2;
        private Label lbDurationLeft;
        private Label label7;
    }
}
