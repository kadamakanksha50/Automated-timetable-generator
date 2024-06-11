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
    public partial class SemesterCirculum : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        string dep = "";
        public SemesterCirculum()
        {
            InitializeComponent();
        }
        public SemesterCirculum(string dep)
        {
            InitializeComponent();
            this.dep = dep;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HODForm form =(HODForm) this.ParentForm;
            form.panelContainer.Controls.Clear();
        }

        private void SemesterCirculum_Load(object sender, EventArgs e)
        {
            comboBox4.Enabled = false;
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Items.Clear();
            }
            comboBox1.Items.Add("SELECT ACADEMIC YEAR");
            dbHelper.fillCombo("SELECT AcademicYear FROM semester_master", comboBox1);
            comboBox1.SelectedIndex = 0;
            panelHoliday.Visible = false;
            panelMidTest.Visible = false;
            panelSubmission.Visible = false;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to add this holiday schedule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.Yes)
            {
                if (cmbHoliday.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select holiday schedule !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                String query = "INSERT INTO semester_ciriculum (Department, SemesterName, AcademicYear, HolidaySchedule) VALUES ('" + dep + "', '" + comboBox4.Text + "', '" + comboBox1.Text + "', '" + cmbHoliday.Text + "') ON DUPLICATE KEY UPDATE  Department = VALUES(Department),SemesterName = VALUES(SemesterName),AcademicYear = VALUES(AcademicYear),HolidaySchedule=VALUES(HolidaySchedule);";
                bool res = dbHelper.TableOperation(query);
                if (res)
                {
                    MessageBox.Show("Holiday schedule added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to add this MidTest schedule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.Yes)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select mid test schedule !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                String query = "INSERT INTO semester_ciriculum (Department, SemesterName, AcademicYear, MidTestSchedule) VALUES ('" + dep + "', '" + comboBox4.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "') ON DUPLICATE KEY UPDATE  Department = VALUES(Department),SemesterName = VALUES(SemesterName),AcademicYear = VALUES(AcademicYear),MidTestSchedule=VALUES(MidTestSchedule);";
                bool res = dbHelper.TableOperation(query);
                if (res)
                {
                    MessageBox.Show("MidTest schedule added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to add this Submission schedule?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.Yes)
            {
                if (comboBox3.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select submission schedule !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                String query = "INSERT INTO semester_ciriculum (Department, SemesterName, AcademicYear, SubmissionSchedule) VALUES ('" + dep + "', '" + comboBox4.Text + "', '" + comboBox1.Text + "', '" + comboBox3.Text + "') ON DUPLICATE KEY UPDATE  Department = VALUES(Department),SemesterName = VALUES(SemesterName),AcademicYear = VALUES(AcademicYear),SubmissionSchedule=VALUES(SubmissionSchedule);";
                bool res = dbHelper.TableOperation(query);
                if (res)
                {
                    MessageBox.Show("Submission schedule added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelHoliday.Visible = true;
            panelMidTest.Visible = false;
            panelSubmission.Visible = false;
            panelHoliday.BringToFront();
            
            String query = "INSERT INTO semester_ciriculum (Department, SemesterName, AcademicYear, HolidaySchedule) VALUES ('" + dep + "', '" + comboBox4.Text + "', '" + comboBox1.Text + "', '" + cmbHoliday.Text + "') ON DUPLICATE KEY UPDATE  Department = VALUES(Department),SemesterName = VALUES(SemesterName),AcademicYear = VALUES(AcademicYear),HolidaySchedule=VALUES(HolidaySchedule);";
            bool res = dbHelper.TableOperation(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelHoliday.Visible = false;
            panelMidTest.Visible = true;
            panelSubmission.Visible = false;
            panelMidTest.BringToFront();
           
            String query = "INSERT INTO semester_ciriculum (Department, SemesterName, AcademicYear, MidTestSchedule) VALUES ('" + dep + "', '" + comboBox4.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "') ON DUPLICATE KEY UPDATE  Department = VALUES(Department),SemesterName = VALUES(SemesterName),AcademicYear = VALUES(AcademicYear),MidTestSchedule=VALUES(MidTestSchedule);";
            bool res = dbHelper.TableOperation(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelHoliday.Visible = false;
            panelMidTest.Visible = false;
            panelSubmission.Visible = true;
            panelSubmission.BringToFront();
            panelMidTest.SendToBack();
            panelHoliday.SendToBack();
            String query = "INSERT INTO semester_ciriculum (Department, SemesterName, AcademicYear, SubmissionSchedule) VALUES ('" + dep + "', '" + comboBox4.Text + "', '" + comboBox1.Text + "', '" + comboBox3.Text + "') ON DUPLICATE KEY UPDATE  Department = VALUES(Department),SemesterName = VALUES(SemesterName),AcademicYear = VALUES(AcademicYear),SubmissionSchedule=VALUES(SubmissionSchedule);";
            bool res = dbHelper.TableOperation(query);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { return; }
            comboBox4.Enabled = true;
            if (comboBox4.Items.Count > 0)
            {
                comboBox4.Items.Clear();
            }
            comboBox4.Items.Add("SELECT SEMESTER");
            dbHelper.fillCombo("SELECT SemesterName FROM semester_master WHERE AcademicYear='" + comboBox1.Text + "'", comboBox4);
            comboBox4.SelectedIndex = 0;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0) { groupBox1.Visible = false; return; }
            groupBox1.Visible = true;
            string holiday = dbHelper.getInfo("SELECT HolidaySchedule FROM semester_ciriculum WHERE Department='" + dep + "' AND AcademicYear='" + comboBox1.Text + "' AND SemesterName='" + comboBox4.Text + "'");
            string midTest = dbHelper.getInfo("SELECT MidTestSchedule FROM semester_ciriculum WHERE Department='" + dep + "' AND AcademicYear='" + comboBox1.Text + "' AND SemesterName='" + comboBox4.Text + "'");
            string submission = dbHelper.getInfo("SELECT SubmissionSchedule FROM semester_ciriculum WHERE Department='" + dep + "' AND AcademicYear='" + comboBox1.Text + "' AND SemesterName='" + comboBox4.Text + "'");
            if (holiday == "")
            {
                holiday = dbHelper.getInfo("SELECT HolidaySchedule FROM semester_ciriculum WHERE AcademicYear='" + comboBox1.Text + "' AND SemesterName='" + comboBox4.Text + "'");
                cmbHoliday.Text=holiday;                
            }
            else cmbHoliday.Text = holiday;
            if (midTest == "")
            {
                comboBox2.SelectedIndex = 0;
                midTest = dbHelper.getInfo("SELECT MidTestSchedule FROM semester_ciriculum WHERE AcademicYear='" + comboBox1.Text + "' AND SemesterName='" + comboBox4.Text + "'");
                comboBox2.Text = midTest;
            }
            else comboBox2.Text = midTest;
            if (submission == "")
            {
                submission = dbHelper.getInfo("SELECT SubmissionSchedule FROM semester_ciriculum WHERE AcademicYear='" + comboBox1.Text + "' AND SemesterName='" + comboBox4.Text + "'");
                comboBox3.Text=submission;
            }
            else comboBox3.Text = submission;
        }
    }
}
