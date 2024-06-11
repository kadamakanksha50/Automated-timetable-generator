namespace AutomatedTimeTable
{
    partial class Semester
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
            panel2 = new Panel();
            lbSrNo = new Label();
            label9 = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            btnSave = new Button();
            btnNew = new Button();
            txtHours = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txtTo = new DateTimePicker();
            label6 = new Label();
            txtFrom = new DateTimePicker();
            label5 = new Label();
            cmbYear = new ComboBox();
            txtSemName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            gridSemesterList = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSemesterList).BeginInit();
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
            panel1.Size = new Size(990, 55);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(920, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 55);
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
            label1.Size = new Size(216, 55);
            label1.TabIndex = 0;
            label1.Text = "Add Semester";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbSrNo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(txtHours);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(cmbYear);
            panel2.Controls.Add(txtSemName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 259);
            panel2.TabIndex = 1;
            // 
            // lbSrNo
            // 
            lbSrNo.AutoSize = true;
            lbSrNo.BackColor = Color.Yellow;
            lbSrNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSrNo.Location = new Point(99, 27);
            lbSrNo.Name = "lbSrNo";
            lbSrNo.Size = new Size(74, 28);
            lbSrNo.TabIndex = 27;
            lbSrNo.Text = "Sr No :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(19, 26);
            label9.Name = "label9";
            label9.Size = new Size(74, 28);
            label9.TabIndex = 26;
            label9.Text = "Sr No :";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSeaGreen;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(700, 194);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 42);
            btnCancel.TabIndex = 25;
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
            btnUpdate.Location = new Point(256, 194);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 42);
            btnUpdate.TabIndex = 24;
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
            btnDel.Location = new Point(404, 194);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(142, 42);
            btnDel.TabIndex = 23;
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
            btnSave.Location = new Point(552, 194);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 42);
            btnSave.TabIndex = 22;
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
            btnNew.Location = new Point(108, 194);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(142, 42);
            btnNew.TabIndex = 21;
            btnNew.Text = "Add New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // txtHours
            // 
            txtHours.BorderStyle = BorderStyle.FixedSingle;
            txtHours.CharacterCasing = CharacterCasing.Upper;
            txtHours.Location = new Point(732, 121);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(243, 34);
            txtHours.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(587, 121);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 5;
            label7.Text = "No Of Hours :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFrom);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(19, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 102);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Semester Duration";
            // 
            // txtTo
            // 
            txtTo.Format = DateTimePickerFormat.Short;
            txtTo.Location = new Point(329, 45);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(184, 34);
            txtTo.TabIndex = 3;
            txtTo.ValueChanged += txtTo_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(276, 47);
            label6.Name = "label6";
            label6.Size = new Size(44, 28);
            label6.TabIndex = 2;
            label6.Text = "To :";
            // 
            // txtFrom
            // 
            txtFrom.Format = DateTimePickerFormat.Short;
            txtFrom.Location = new Point(81, 45);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(184, 34);
            txtFrom.TabIndex = 1;
            txtFrom.ValueChanged += txtFrom_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 47);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 0;
            label5.Text = "From :";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(732, 24);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(243, 36);
            cmbYear.TabIndex = 3;
            // 
            // txtSemName
            // 
            txtSemName.BorderStyle = BorderStyle.FixedSingle;
            txtSemName.CharacterCasing = CharacterCasing.Upper;
            txtSemName.Location = new Point(295, 24);
            txtSemName.Name = "txtSemName";
            txtSemName.Size = new Size(251, 34);
            txtSemName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(572, 24);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 1;
            label4.Text = "Academic Year :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(207, 27);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 0;
            label3.Text = "Name :";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(990, 43);
            panel3.TabIndex = 2;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(990, 43);
            label8.TabIndex = 0;
            label8.Text = "Semester List";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gridSemesterList
            // 
            gridSemesterList.AllowUserToAddRows = false;
            gridSemesterList.AllowUserToDeleteRows = false;
            gridSemesterList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gridSemesterList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridSemesterList.BackgroundColor = SystemColors.Control;
            gridSemesterList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridSemesterList.DefaultCellStyle = dataGridViewCellStyle1;
            gridSemesterList.Dock = DockStyle.Fill;
            gridSemesterList.Location = new Point(0, 357);
            gridSemesterList.MultiSelect = false;
            gridSemesterList.Name = "gridSemesterList";
            gridSemesterList.ReadOnly = true;
            gridSemesterList.RowHeadersVisible = false;
            gridSemesterList.RowHeadersWidth = 51;
            gridSemesterList.RowTemplate.Height = 29;
            gridSemesterList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSemesterList.Size = new Size(990, 302);
            gridSemesterList.TabIndex = 3;
            gridSemesterList.CellContentClick += gridSemesterList_CellContentClick;
            // 
            // Semester
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(gridSemesterList);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Semester";
            Size = new Size(990, 659);
            Load += Semester_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSemesterList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private DateTimePicker txtTo;
        private Label label6;
        private DateTimePicker txtFrom;
        private Label label5;
        private ComboBox cmbYear;
        private TextBox txtSemName;
        private Label label4;
        private Label label3;
        private TextBox txtHours;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDel;
        private Button btnSave;
        private Button btnNew;
        private DataGridView gridSemesterList;
        private Label lbSrNo;
        private Label label9;
    }
}
