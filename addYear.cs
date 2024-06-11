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
    public partial class addYear : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        string status = "";
        public addYear()
        {
            InitializeComponent();
        }
        public void clear()
        {
            lbSrNo.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";
        }
        public void unlockAll(bool b)
        {
            lbSrNo.Enabled = b;
            txtFrom.Enabled = b;
            txtTo.Enabled = b;
        }
        public void actionButtonNormalStage()
        {
            btnCancel.Enabled = false;
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnNew.Enabled = true;
        }
        public void actionButtonEditStage()
        {
            btnCancel.Enabled = true;
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            btnNew.Enabled = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gridYearList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbSrNo.Text = gridYearList.CurrentRow.Cells[0].Value.ToString();
            String? data = gridYearList.CurrentRow.Cells[1].Value.ToString();
            if (data != string.Empty)
            {
                String[] arr = data.Split("-");
                txtFrom.Text = arr[0];
                txtTo.Text = arr[1];
            }
            unlockAll(false);
            actionButtonNormalStage();
            btnNew.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
            unlockAll(true);
            actionButtonEditStage();
            lbSrNo.Text = dbHelper.getSrNo("SELECT MAX(SrNo) FROM year_master").ToString();
            status = "Add New";
        }
        public void fillgrid()
        {
            if (gridYearList.Rows.Count > 0)
            {
                gridYearList.DataSource = null;
                gridYearList.Rows.Clear();
            }
            dbHelper.show("Select * From year_master", gridYearList);
            gridYearList.ClearSelection();
            gridYearList.CurrentCell = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "Add New")
            {
                DialogResult drs = MessageBox.Show("Are you sure do you want to add this academic year?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                string year = txtFrom.Text + "-" + txtTo.Text;
                string query = "INSERT INTO year_master VALUES(" + lbSrNo.Text + ",'" + year + "');";
                bool result = dbHelper.TableOperation(query);
                if (result)
                {
                    MessageBox.Show("Academic year added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult drs = MessageBox.Show("Are you sure do you want to update this academic year?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                string year = txtFrom.Text + "-" + txtTo.Text;
                string query = "UPDATE year_master SET AcademicYear='" + year + "' WHERE SrNo=" + lbSrNo.Text;
                bool result = dbHelper.TableOperation(query);
                if (result)
                {
                    MessageBox.Show("Academic year updated successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    unlockAll(false);
                    actionButtonNormalStage();
                }
                else
                {
                    MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            fillgrid();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to delete this academic year?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.No) { return; }
            String query = "DELETE FROM year_master WHERE SrNo=" + lbSrNo.Text;
            Boolean result = dbHelper.TableOperation(query);
            if (result)
            {
                MessageBox.Show("Academic year deleted successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                unlockAll(false);
                actionButtonNormalStage();
            }
            else
            {
                MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fillgrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlockAll(true);
            actionButtonEditStage();
            status = "Update";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            actionButtonNormalStage();
            clear();
            unlockAll(false);
            fillgrid();
        }
    }
}
