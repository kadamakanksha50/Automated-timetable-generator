namespace AutomatedTimeTable
{
    partial class Addclass
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtYear = new ComboBox();
            btnCancel = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            gridClassList = new DataGridView();
            panel4 = new Panel();
            label7 = new Label();
            btnUpdate = new Button();
            btnDel = new Button();
            btnSave = new Button();
            btnNew = new Button();
            txtDiv = new MaskedTextBox();
            cmbDep = new ComboBox();
            lbClassName = new Label();
            lbSrNo = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClassList).BeginInit();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(1247, 55);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1195, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 55);
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
            label1.Size = new Size(198, 55);
            label1.TabIndex = 0;
            label1.Text = "Add your class";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtYear);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(txtDiv);
            panel2.Controls.Add(cmbDep);
            panel2.Controls.Add(lbClassName);
            panel2.Controls.Add(lbSrNo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(1247, 749);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtYear
            // 
            txtYear.DropDownStyle = ComboBoxStyle.DropDownList;
            txtYear.FormattingEnabled = true;
            txtYear.Location = new Point(108, 100);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(183, 36);
            txtYear.TabIndex = 16;
            txtYear.SelectedIndexChanged += txtyear_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSeaGreen;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1012, 147);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 42);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(1243, 551);
            panel3.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Controls.Add(gridClassList);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(1241, 505);
            panel5.TabIndex = 1;
            // 
            // gridClassList
            // 
            gridClassList.AllowUserToAddRows = false;
            gridClassList.AllowUserToDeleteRows = false;
            gridClassList.AllowUserToResizeColumns = false;
            gridClassList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            gridClassList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridClassList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClassList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridClassList.BackgroundColor = SystemColors.ButtonFace;
            gridClassList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridClassList.DefaultCellStyle = dataGridViewCellStyle2;
            gridClassList.Dock = DockStyle.Fill;
            gridClassList.Location = new Point(0, 0);
            gridClassList.MultiSelect = false;
            gridClassList.Name = "gridClassList";
            gridClassList.ReadOnly = true;
            gridClassList.RowHeadersVisible = false;
            gridClassList.RowHeadersWidth = 51;
            gridClassList.RowTemplate.Height = 29;
            gridClassList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClassList.Size = new Size(1241, 505);
            gridClassList.TabIndex = 0;
            gridClassList.CellContentClick += gridClassList_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1241, 44);
            panel4.TabIndex = 0;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(1241, 44);
            label7.TabIndex = 1;
            label7.Text = "Class List";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(716, 93);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 42);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.DarkRed;
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(864, 93);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(142, 42);
            btnDel.TabIndex = 12;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.OrangeRed;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1012, 93);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 42);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(0, 64, 0);
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(1012, 39);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(142, 42);
            btnNew.TabIndex = 10;
            btnNew.Text = "Add New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // txtDiv
            // 
            txtDiv.BorderStyle = BorderStyle.FixedSingle;
            txtDiv.Location = new Point(398, 101);
            txtDiv.Mask = "A";
            txtDiv.Name = "txtDiv";
            txtDiv.Size = new Size(261, 34);
            txtDiv.TabIndex = 9;
            txtDiv.MaskInputRejected += txtDiv_MaskInputRejected;
            txtDiv.TextChanged += txtDiv_TextChanged;
            txtDiv.KeyPress += txtDiv_KeyPress;
            // 
            // cmbDep
            // 
            cmbDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDep.FlatStyle = FlatStyle.System;
            cmbDep.FormattingEnabled = true;
            cmbDep.Items.AddRange(new object[] { "SELECT", "CSE", "AIDS", "EEE", "ECE" });
            cmbDep.Location = new Point(398, 45);
            cmbDep.Name = "cmbDep";
            cmbDep.Size = new Size(261, 36);
            cmbDep.TabIndex = 8;
            cmbDep.SelectedIndexChanged += cmbDep_SelectedIndexChanged;
            // 
            // lbClassName
            // 
            lbClassName.AutoSize = true;
            lbClassName.BackColor = Color.Yellow;
            lbClassName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbClassName.Location = new Point(850, 45);
            lbClassName.Name = "lbClassName";
            lbClassName.Size = new Size(74, 28);
            lbClassName.TabIndex = 6;
            lbClassName.Text = "Sr No :";
            // 
            // lbSrNo
            // 
            lbSrNo.AutoSize = true;
            lbSrNo.BackColor = Color.Yellow;
            lbSrNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSrNo.Location = new Point(108, 45);
            lbSrNo.Name = "lbSrNo";
            lbSrNo.Size = new Size(74, 28);
            lbSrNo.TabIndex = 5;
            lbSrNo.Text = "Sr No :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(716, 45);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 4;
            label8.Text = "Class Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(297, 101);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 3;
            label5.Text = "Division :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(259, 45);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 2;
            label6.Text = "Department :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 101);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 1;
            label4.Text = "Year :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 45);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 0;
            label3.Text = "Sr No :";
            // 
            // Addclass
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Addclass";
            Size = new Size(1247, 804);
            Load += Addclass_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClassList).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label lbSrNo;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private MaskedTextBox txtDiv;
        private ComboBox cmbDep;
        private Label lbClassName;
        private Panel panel3;
        private Panel panel5;
        private DataGridView gridClassList;
        private Panel panel4;
        private Label label7;
        private Button btnUpdate;
        private Button btnDel;
        private Button btnSave;
        private Button btnNew;
        private Button btnCancel;
        private ComboBox txtYear;
    }
}
