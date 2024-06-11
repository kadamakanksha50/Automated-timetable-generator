namespace AutomatedTimeTable
{
    partial class Teachers
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            btnSave = new Button();
            btnNew = new Button();
            panel3 = new Panel();
            txtPassword = new TextBox();
            label8 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            panelClassTeacher = new Panel();
            cmbAssignClassName = new ComboBox();
            label19 = new Label();
            panelHod = new Panel();
            cmbHODDep = new ComboBox();
            label18 = new Label();
            cmbAssign = new ComboBox();
            label17 = new Label();
            txtAdd = new TextBox();
            label16 = new Label();
            txtEmail = new TextBox();
            label15 = new Label();
            txtMob = new MaskedTextBox();
            label14 = new Label();
            cmbQual = new ComboBox();
            label13 = new Label();
            cmbDepartment = new ComboBox();
            label12 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            btnBrowse = new Button();
            pictureBox1 = new PictureBox();
            txtLastName = new TextBox();
            label11 = new Label();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            lbAliasName = new Label();
            label7 = new Label();
            cmbTitle = new ComboBox();
            label6 = new Label();
            lbTeacherCode = new Label();
            label4 = new Label();
            panel4 = new Panel();
            panel7 = new Panel();
            gridTeacherList = new DataGridView();
            panel6 = new Panel();
            textBox1 = new TextBox();
            label20 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelClassTeacher.SuspendLayout();
            panelHod.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTeacherList).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.Size = new Size(1644, 55);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1578, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 55);
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
            label1.Size = new Size(274, 55);
            label1.TabIndex = 0;
            label1.Text = "Add Teachers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSeaGreen;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(712, 613);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 42);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(268, 613);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 42);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.DarkRed;
            btnDel.Cursor = Cursors.Hand;
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(416, 613);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(142, 42);
            btnDel.TabIndex = 28;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.OrangeRed;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(564, 613);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 42);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(0, 64, 0);
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(120, 613);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(142, 42);
            btnNew.TabIndex = 26;
            btnNew.Text = "Add New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(panelClassTeacher);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(panelHod);
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(cmbAssign);
            panel3.Controls.Add(btnDel);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(txtAdd);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(txtMob);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(cmbQual);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cmbDepartment);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtMiddleName);
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lbAliasName);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmbTitle);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lbTeacherCode);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(958, 695);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(578, 504);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 34);
            txtPassword.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(458, 506);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 33;
            label8.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(148, 502);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 34);
            txtUsername.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 504);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 31;
            label5.Text = "Username :";
            // 
            // panelClassTeacher
            // 
            panelClassTeacher.Controls.Add(cmbAssignClassName);
            panelClassTeacher.Controls.Add(label19);
            panelClassTeacher.Location = new Point(380, 399);
            panelClassTeacher.Name = "panelClassTeacher";
            panelClassTeacher.Size = new Size(555, 87);
            panelClassTeacher.TabIndex = 27;
            // 
            // cmbAssignClassName
            // 
            cmbAssignClassName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssignClassName.FlatStyle = FlatStyle.System;
            cmbAssignClassName.FormattingEnabled = true;
            cmbAssignClassName.Location = new Point(152, 28);
            cmbAssignClassName.Name = "cmbAssignClassName";
            cmbAssignClassName.Size = new Size(217, 36);
            cmbAssignClassName.TabIndex = 28;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(15, 30);
            label19.Name = "label19";
            label19.Size = new Size(128, 28);
            label19.TabIndex = 27;
            label19.Text = "Class Name :";
            // 
            // panelHod
            // 
            panelHod.Controls.Add(cmbHODDep);
            panelHod.Controls.Add(label18);
            panelHod.Location = new Point(380, 398);
            panelHod.Name = "panelHod";
            panelHod.Size = new Size(555, 87);
            panelHod.TabIndex = 26;
            // 
            // cmbHODDep
            // 
            cmbHODDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHODDep.FlatStyle = FlatStyle.System;
            cmbHODDep.FormattingEnabled = true;
            cmbHODDep.Items.AddRange(new object[] { "SELECT", "CSE", "AIDS", "EEE", "ECE" });
            cmbHODDep.Location = new Point(152, 28);
            cmbHODDep.Name = "cmbHODDep";
            cmbHODDep.Size = new Size(217, 36);
            cmbHODDep.TabIndex = 28;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(15, 30);
            label18.Name = "label18";
            label18.Size = new Size(133, 28);
            label18.TabIndex = 27;
            label18.Text = "Department :";
            // 
            // cmbAssign
            // 
            cmbAssign.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssign.FlatStyle = FlatStyle.System;
            cmbAssign.FormattingEnabled = true;
            cmbAssign.Items.AddRange(new object[] { "SELECT", "Class Teacher", "HOD", "Faculty" });
            cmbAssign.Location = new Point(148, 425);
            cmbAssign.Name = "cmbAssign";
            cmbAssign.Size = new Size(201, 36);
            cmbAssign.TabIndex = 25;
            cmbAssign.SelectedIndexChanged += cmbAssign_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(33, 428);
            label17.Name = "label17";
            label17.Size = new Size(110, 28);
            label17.TabIndex = 24;
            label17.Text = "Assign To :";
            // 
            // txtAdd
            // 
            txtAdd.BorderStyle = BorderStyle.FixedSingle;
            txtAdd.Location = new Point(148, 320);
            txtAdd.Multiline = true;
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(774, 72);
            txtAdd.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(47, 322);
            label16.Name = "label16";
            label16.Size = new Size(96, 28);
            label16.TabIndex = 22;
            label16.Text = "Address :";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(525, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(411, 34);
            txtEmail.TabIndex = 21;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(422, 265);
            label15.Name = "label15";
            label15.Size = new Size(95, 28);
            label15.TabIndex = 20;
            label15.Text = "Email Id :";
            // 
            // txtMob
            // 
            txtMob.BorderStyle = BorderStyle.FixedSingle;
            txtMob.Location = new Point(148, 263);
            txtMob.Mask = "0000000000";
            txtMob.Name = "txtMob";
            txtMob.Size = new Size(201, 34);
            txtMob.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(24, 265);
            label14.Name = "label14";
            label14.Size = new Size(119, 28);
            label14.TabIndex = 18;
            label14.Text = "Mobile No :";
            // 
            // cmbQual
            // 
            cmbQual.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQual.FlatStyle = FlatStyle.System;
            cmbQual.FormattingEnabled = true;
            cmbQual.Items.AddRange(new object[] { "SELECT", "Graduation", "Post Graducation", "PHD" });
            cmbQual.Location = new Point(525, 197);
            cmbQual.Name = "cmbQual";
            cmbQual.Size = new Size(224, 36);
            cmbQual.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(382, 200);
            label13.Name = "label13";
            label13.Size = new Size(137, 28);
            label13.TabIndex = 16;
            label13.Text = "Qualification :";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FlatStyle = FlatStyle.System;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "SELECT", "CSE", "AIDS", "EEE", "ECE" });
            cmbDepartment.Location = new Point(148, 197);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(201, 36);
            cmbDepartment.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(10, 200);
            label12.Name = "label12";
            label12.Size = new Size(133, 28);
            label12.TabIndex = 14;
            label12.Text = "Department :";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(773, 16);
            panel8.Name = "panel8";
            panel8.Size = new Size(163, 231);
            panel8.TabIndex = 13;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnBrowse);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 174);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(8, 5, 8, 5);
            panel9.Size = new Size(161, 55);
            panel9.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Dock = DockStyle.Bottom;
            btnBrowse.Location = new Point(8, 6);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(145, 44);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.teacher;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(148, 140);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(201, 34);
            txtLastName.TabIndex = 12;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(24, 143);
            label11.Name = "label11";
            label11.Size = new Size(119, 28);
            label11.TabIndex = 11;
            label11.Text = "Last Name :";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Location = new Point(525, 83);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(224, 34);
            txtMiddleName.TabIndex = 10;
            txtMiddleName.TextChanged += txtMiddleName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(148, 84);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(201, 34);
            txtFirstName.TabIndex = 9;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(371, 86);
            label10.Name = "label10";
            label10.Size = new Size(146, 28);
            label10.TabIndex = 7;
            label10.Text = "Middle Name :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(22, 85);
            label9.Name = "label9";
            label9.Size = new Size(121, 28);
            label9.TabIndex = 6;
            label9.Text = "First Name :";
            // 
            // lbAliasName
            // 
            lbAliasName.AutoSize = true;
            lbAliasName.BackColor = Color.Yellow;
            lbAliasName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAliasName.Location = new Point(525, 146);
            lbAliasName.Name = "lbAliasName";
            lbAliasName.Size = new Size(77, 28);
            lbAliasName.TabIndex = 5;
            lbAliasName.Text = "#Alias :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(440, 146);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 4;
            label7.Text = "#Alias :";
            // 
            // cmbTitle
            // 
            cmbTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTitle.FlatStyle = FlatStyle.System;
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Items.AddRange(new object[] { "SELECT", "Mr.", "Mrs.", "Miss" });
            cmbTitle.Location = new Point(525, 31);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(224, 36);
            cmbTitle.TabIndex = 3;
            cmbTitle.SelectedIndexChanged += cmbTitle_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(455, 34);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 2;
            label6.Text = "Title :";
            // 
            // lbTeacherCode
            // 
            lbTeacherCode.AutoSize = true;
            lbTeacherCode.BackColor = Color.Yellow;
            lbTeacherCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTeacherCode.Location = new Point(148, 34);
            lbTeacherCode.Name = "lbTeacherCode";
            lbTeacherCode.Size = new Size(82, 28);
            lbTeacherCode.TabIndex = 1;
            lbTeacherCode.Text = "#Code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 34);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 0;
            label4.Text = "#Code :";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(958, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(686, 695);
            panel4.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(gridTeacherList);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 99);
            panel7.Name = "panel7";
            panel7.Size = new Size(686, 596);
            panel7.TabIndex = 2;
            // 
            // gridTeacherList
            // 
            gridTeacherList.AllowUserToAddRows = false;
            gridTeacherList.AllowUserToDeleteRows = false;
            gridTeacherList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gridTeacherList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridTeacherList.BackgroundColor = SystemColors.Control;
            gridTeacherList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridTeacherList.DefaultCellStyle = dataGridViewCellStyle1;
            gridTeacherList.Dock = DockStyle.Fill;
            gridTeacherList.Location = new Point(0, 0);
            gridTeacherList.MultiSelect = false;
            gridTeacherList.Name = "gridTeacherList";
            gridTeacherList.ReadOnly = true;
            gridTeacherList.RowHeadersVisible = false;
            gridTeacherList.RowHeadersWidth = 51;
            gridTeacherList.RowTemplate.Height = 29;
            gridTeacherList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTeacherList.Size = new Size(684, 594);
            gridTeacherList.TabIndex = 0;
            gridTeacherList.CellContentClick += gridTeacherList_CellContentClick;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(label20);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 42);
            panel6.Name = "panel6";
            panel6.Size = new Size(686, 57);
            panel6.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(225, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 34);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(142, 12);
            label20.Name = "label20";
            label20.Size = new Size(77, 28);
            label20.TabIndex = 5;
            label20.Text = "#Alias :";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(686, 42);
            panel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(686, 42);
            label3.TabIndex = 0;
            label3.Text = "Teacher List";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Teachers
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Teachers";
            Size = new Size(1644, 750);
            Load += Teachers_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelClassTeacher.ResumeLayout(false);
            panelClassTeacher.PerformLayout();
            panelHod.ResumeLayout(false);
            panelHod.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTeacherList).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
        private DataGridView gridTeacherList;
        private Panel panel6;
        private Panel panel5;
        private Label label3;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDel;
        private Button btnSave;
        private Button btnNew;
        private Label label4;
        private TextBox txtMiddleName;
        private TextBox txtFirstName;
        private Label label10;
        private Label label9;
        private Label lbAliasName;
        private Label label7;
        private ComboBox cmbTitle;
        private Label label6;
        private Label lbTeacherCode;
        private Panel panel8;
        private Panel panel9;
        private Button btnBrowse;
        private PictureBox pictureBox1;
        private TextBox txtLastName;
        private Label label11;
        private ComboBox cmbDepartment;
        private Label label12;
        private ComboBox cmbAssign;
        private Label label17;
        private TextBox txtAdd;
        private Label label16;
        private TextBox txtEmail;
        private Label label15;
        private MaskedTextBox txtMob;
        private Label label14;
        private ComboBox cmbQual;
        private Label label13;
        private Panel panelHod;
        private Panel panelClassTeacher;
        private ComboBox cmbAssignClassName;
        private Label label19;
        private ComboBox cmbHODDep;
        private Label label18;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtUsername;
        private Label label5;
        private TextBox textBox1;
        private Label label20;
    }
}
