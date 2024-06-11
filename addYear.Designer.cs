namespace AutomatedTimeTable
{
    partial class addYear
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
            btnCancel = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            btnSave = new Button();
            btnNew = new Button();
            groupBox1 = new GroupBox();
            txtTo = new MaskedTextBox();
            label7 = new Label();
            txtFrom = new MaskedTextBox();
            label6 = new Label();
            lbSrNo = new Label();
            label4 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            gridYearList = new DataGridView();
            panel4 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridYearList).BeginInit();
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
            panel1.Size = new Size(849, 61);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(777, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 61);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 61);
            label1.TabIndex = 0;
            label1.Text = "Add Academic Year";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lbSrNo);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 203);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSeaGreen;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(639, 141);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 42);
            btnCancel.TabIndex = 20;
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
            btnUpdate.Location = new Point(195, 141);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 42);
            btnUpdate.TabIndex = 19;
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
            btnDel.Location = new Point(343, 141);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(142, 42);
            btnDel.TabIndex = 18;
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
            btnSave.Location = new Point(491, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 42);
            btnSave.TabIndex = 17;
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
            btnNew.Location = new Point(47, 141);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(142, 42);
            btnNew.TabIndex = 16;
            btnNew.Text = "Add New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFrom);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(225, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 95);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Academic Year";
            // 
            // txtTo
            // 
            txtTo.BorderStyle = BorderStyle.FixedSingle;
            txtTo.Location = new Point(337, 39);
            txtTo.Mask = "0000";
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(125, 34);
            txtTo.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(287, 43);
            label7.Name = "label7";
            label7.Size = new Size(44, 28);
            label7.TabIndex = 3;
            label7.Text = "To :";
            // 
            // txtFrom
            // 
            txtFrom.BorderStyle = BorderStyle.FixedSingle;
            txtFrom.Location = new Point(142, 39);
            txtFrom.Mask = "0000";
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(125, 34);
            txtFrom.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(66, 39);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 1;
            label6.Text = "From :";
            // 
            // lbSrNo
            // 
            lbSrNo.AutoSize = true;
            lbSrNo.BackColor = Color.Yellow;
            lbSrNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSrNo.Location = new Point(123, 57);
            lbSrNo.Name = "lbSrNo";
            lbSrNo.Size = new Size(74, 28);
            lbSrNo.TabIndex = 0;
            lbSrNo.Text = "Sr No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 57);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 0;
            label4.Text = "Sr No :";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 270);
            panel3.Name = "panel3";
            panel3.Size = new Size(849, 299);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(gridYearList);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(847, 258);
            panel5.TabIndex = 1;
            // 
            // gridYearList
            // 
            gridYearList.AllowUserToAddRows = false;
            gridYearList.AllowUserToDeleteRows = false;
            gridYearList.AllowUserToResizeColumns = false;
            gridYearList.AllowUserToResizeRows = false;
            gridYearList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridYearList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridYearList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridYearList.DefaultCellStyle = dataGridViewCellStyle1;
            gridYearList.Dock = DockStyle.Fill;
            gridYearList.Location = new Point(0, 0);
            gridYearList.MultiSelect = false;
            gridYearList.Name = "gridYearList";
            gridYearList.ReadOnly = true;
            gridYearList.RowHeadersVisible = false;
            gridYearList.RowHeadersWidth = 51;
            gridYearList.RowTemplate.Height = 29;
            gridYearList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridYearList.Size = new Size(847, 258);
            gridYearList.TabIndex = 0;
            gridYearList.CellContentClick += gridYearList_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(847, 39);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(847, 39);
            label3.TabIndex = 0;
            label3.Text = "Academic Year List";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addYear
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "addYear";
            Size = new Size(849, 569);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridYearList).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private DataGridView gridYearList;
        private Panel panel4;
        private Label label3;
        private GroupBox groupBox1;
        private MaskedTextBox txtTo;
        private Label label7;
        private MaskedTextBox txtFrom;
        private Label label6;
        private Label lbSrNo;
        private Label label4;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDel;
        private Button btnSave;
        private Button btnNew;
    }
}
