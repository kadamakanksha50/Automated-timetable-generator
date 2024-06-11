using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutomatedTimeTable
{
    public partial class Addclass : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        string status = "";
        public Addclass()
        {
            InitializeComponent();
            if (gridClassList.Rows.Count > 0)
            {
                gridClassList.DataSource = null;
                gridClassList.Rows.Clear();
            }
            dbHelper.show("Select * From class_master", gridClassList);
            gridClassList.ClearSelection();
            gridClassList.CurrentCell = null;
        }
        public void clear()
        {
            txtDiv.Clear();
            if (txtYear.Items.Count > 0)
            {
                txtYear.Items.Clear();
            }
            txtYear.Items.Add("Select Year");
            dbHelper.fillCombo("SELECT AcademicYear from year_master", txtYear);
            txtYear.SelectedIndex = 0;
            lbClassName.Text = string.Empty;
            lbSrNo.Text = string.Empty;
            cmbDep.SelectedIndex = 0;

        }
        public void unlockAll(bool b)
        {
            txtDiv.Enabled = b;
            txtYear.Enabled = b;
            cmbDep.Enabled = b;
        }
        public void actionButtonNormalStage()
        {
            btnNew.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
        }
        public void actionButtonEditStage()
        {
            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addclass_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            actionButtonEditStage();
            unlockAll(true);
            lbSrNo.Text = dbHelper.getSrNo("SELECT MAX(SrNo) FROM class_master").ToString();
            status = "Add New";
        }

        private void txtDiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                txtDiv.Clear();
            }
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }

        }

        private void cmbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDep.SelectedIndex == 0) { return; }
            lbClassName.Text = cmbDep.SelectedItem.ToString() + " - " + txtDiv.Text;
        }

        private void txtDiv_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDiv_TextChanged(object sender, EventArgs e)
        {
            lbClassName.Text = cmbDep.SelectedItem.ToString() + " - " + txtDiv.Text;
        }

        private void gridClassList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbClassName.Text = gridClassList.CurrentRow.Cells[1].Value.ToString();
            lbSrNo.Text = gridClassList.CurrentRow.Cells[0].Value.ToString();
            cmbDep.Text = gridClassList.CurrentRow.Cells[2].Value.ToString();
            txtYear.Text = gridClassList.CurrentRow.Cells[3].Value.ToString();
            txtDiv.Text = gridClassList.CurrentRow.Cells[4].Value.ToString();
            actionButtonNormalStage();
            unlockAll(false);
            btnNew.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            btnDel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "Add New")
            {
                DialogResult drs = MessageBox.Show("Are you sure do you want to add this class?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                String query = "INSERT INTO class_master VALUES (" + lbSrNo.Text + ",'" + lbClassName.Text + "','" + cmbDep.Text + "','" + txtYear.Text + "','" + txtDiv.Text + "');";
                Boolean result = dbHelper.TableOperation(query);
                if (result)
                {
                    MessageBox.Show("Class added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    unlockAll(false);
                    actionButtonNormalStage();
                }
                else
                {
                    MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (status == "Update")
            {
                DialogResult drs = MessageBox.Show("Are you sure do you want to update this class?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                String query = "UPDATE class_master SET ClassName='" + lbClassName.Text + "',Department='" + cmbDep.Text + "',Year='" + txtYear.Text + "',Division='" + txtDiv.Text + "' WHERE SrNo=" + lbSrNo.Text;
                Boolean result = dbHelper.TableOperation(query);
                if (result)
                {
                    MessageBox.Show("Class updated successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    unlockAll(false);
                    actionButtonNormalStage();
                }
                else
                {
                    MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (gridClassList.Rows.Count > 0)
            {
                gridClassList.DataSource = null;
                gridClassList.Rows.Clear();
            }
            dbHelper.show("Select * From class_master", gridClassList);
            gridClassList.ClearSelection();
            gridClassList.CurrentCell = null;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            unlockAll(false);
            actionButtonNormalStage();
            if (gridClassList.Rows.Count > 0)
            {
                gridClassList.DataSource = null;
                gridClassList.Rows.Clear();
            }
            dbHelper.show("Select * From class_master", gridClassList);
            gridClassList.ClearSelection();
            gridClassList.CurrentCell = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlockAll(true);
            actionButtonEditStage();
            status = "Update";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to delete this class?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.No) { return; }
            String query = "DELETE FROM class_master WHERE SrNo=" + lbSrNo.Text;
            Boolean result = dbHelper.TableOperation(query);
            if (result)
            {
                MessageBox.Show("Class deleted successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                unlockAll(false);
                actionButtonNormalStage();
            }
            else
            {
                MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (gridClassList.Rows.Count > 0)
            {
                gridClassList.DataSource = null;
                gridClassList.Rows.Clear();
            }
            dbHelper.show("Select * From class_master", gridClassList);
            gridClassList.ClearSelection();
            gridClassList.CurrentCell = null;

        }

        private void txtyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

