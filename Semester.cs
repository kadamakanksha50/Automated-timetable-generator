using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomatedTimeTable
{
    public partial class Semester : UserControl
    {
        Db_Helper Db_Helper = new Db_Helper();
        string status = "";
        public Semester()
        {
            InitializeComponent();
        }

        private void Semester_Load(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            lbSrNo.Text = "";
            txtSemName.Text = "";
            txtFrom.Text = DateTime.Now.ToShortDateString();
            txtTo.Text = DateTime.Now.ToShortDateString();
            if (cmbYear.Items.Count > 0)
            {
                cmbYear.Items.Clear();
            }
            cmbYear.Items.Add("SELECT YEAR");
            Db_Helper.fillCombo("SELECT AcademicYear From year_master", cmbYear);
            cmbYear.SelectedIndex = 0;
            txtHours.Text = "0";
        }
        public void unlockAll(bool b)
        {
            lbSrNo.Enabled = b;
            txtFrom.Enabled = b;
            txtTo.Enabled = b;
            txtSemName.Enabled = b;
            cmbYear.Enabled = b;
            txtHours.Enabled = b;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            unlockAll(false);
            actionButtonNormalStage();
            status = "";
            fillgrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
            lbSrNo.Text = Db_Helper.getSrNo("SELECT MAX(SrNo) FROM semester_master").ToString();
            status = "Add New";
            actionButtonEditStage();
            unlockAll(true);
            txtSemName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlockAll(true);
            status = "Update";
            actionButtonEditStage();
        }
        public void fillgrid()
        {
            if (gridSemesterList.Rows.Count > 0)
            {
                gridSemesterList.DataSource = null;
                gridSemesterList.Rows.Clear();
            }
            Db_Helper.show("Select * From semester_master", gridSemesterList);
            gridSemesterList.ClearSelection();
            gridSemesterList.CurrentCell = null;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to delete this semester?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.No) { return; }
            String query = "DELETE FROM semester_master WHERE SrNo=" + lbSrNo.Text;
            Boolean result = Db_Helper.TableOperation(query);
            if (result)
            {
                MessageBox.Show("Semester deleted successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private int countWorkingHours(String start, String end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);
            int sundayCount = CountSundays(startDate, endDate);
            int numberOfDays = (endDate - startDate).Days;
            return (numberOfDays - sundayCount - 20) * 7;
        }
        private int CountSundays(DateTime startDate, DateTime endDate)
        {
            int sundayCount = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }

            return sundayCount;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "Add New")
            {
                DialogResult drs = MessageBox.Show("Are you sure do you want to add this academic year?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                string year = txtFrom.Text + " to " + txtTo.Text;

                string query = "INSERT INTO semester_master VALUES(" + lbSrNo.Text + ",'" + txtSemName.Text + "','" + cmbYear.Text + "','" + year + "'," + txtHours.Text + ");";
                bool result = Db_Helper.TableOperation(query);
                query = "INSERT INTO semester_ciriculum (SemesterName, AcademicYear, HolidaySchedule,MidTestSchedule,SubmissionSchedule) VALUES ('" + txtSemName.Text + "', '" + cmbYear.Text + "', 'Sunday','After 75% of Duration','Last 15 days') ON DUPLICATE KEY UPDATE SemesterName = VALUES(SemesterName),AcademicYear = VALUES(AcademicYear),HolidaySchedule=VALUES(HolidaySchedule),MidTestSchedule=VALUES(MidTestSchedule),SubmissionSchedule=VALUES(SubmissionSchedule);";
                bool res = Db_Helper.TableOperation(query);
                if (result)
                {
                    MessageBox.Show("Semester added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string year = txtFrom.Text + " to " + txtTo.Text;
                string query = "UPDATE semester_master SET SemesterName='" + txtSemName.Text + "',AcademicYear='" + cmbYear.Text + "',Duration='" + year + "',NoOfHours=" + txtHours.Text + " WHERE SrNo=" + lbSrNo.Text;
                bool result = Db_Helper.TableOperation(query);
                query = "INSERT INTO semester_ciriculum (SemesterName, AcademicYear, HolidaySchedule,MidTestSchedule,SubmissionSchedule) VALUES ('" + txtSemName.Text + "', '" + cmbYear.Text + "', 'Sunday','After 75% of Duration','Last 15 days') ON DUPLICATE KEY UPDATE SemesterName = VALUES(SemesterName),AcademicYear = VALUES(AcademicYear),HolidaySchedule=VALUES(HolidaySchedule),MidTestSchedule=VALUES(MidTestSchedule),SubmissionSchedule=VALUES(SubmissionSchedule);";
                bool res = Db_Helper.TableOperation(query);
                if (result)
                {
                    MessageBox.Show("Semester updated successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridSemesterList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSemesterList.CurrentRow == null) return;
            unlockAll(false);
            actionButtonNormalStage();
            btnNew.Enabled = false; btnCancel.Enabled = true;
            btnUpdate.Enabled = true; btnDel.Enabled = true;
            lbSrNo.Text = gridSemesterList.CurrentRow.Cells[0].Value.ToString();
            txtSemName.Text = gridSemesterList.CurrentRow.Cells[1].Value.ToString();
            cmbYear.Text = gridSemesterList.CurrentRow.Cells[2].Value.ToString();
            string? data = gridSemesterList.CurrentRow.Cells[3].Value.ToString();
            if (data != string.Empty)
            {
                String[] arr = data.Split("to");
                txtFrom.Text = arr[0];
                txtTo.Text = arr[1];
            }
            txtHours.Text = gridSemesterList.CurrentRow.Cells[4].Value.ToString();

        }

        private void txtFrom_ValueChanged(object sender, EventArgs e)
        {
            txtHours.Text = countWorkingHours(txtFrom.Text, txtTo.Text).ToString();
        }

        private void txtTo_ValueChanged(object sender, EventArgs e)
        {
            txtHours.Text = countWorkingHours(txtFrom.Text, txtTo.Text).ToString();
        }
    }
}
