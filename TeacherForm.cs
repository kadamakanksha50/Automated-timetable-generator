using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTimeTable
{
    public partial class TeacherForm : Form
    {
        Db_Helper dbHelper = new Db_Helper();
        String aliasName = "";
        String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public TeacherForm()
        {
            InitializeComponent();
            timer1.Start();
        }
        public TeacherForm(string user)
        {
            InitializeComponent();
            timer1.Start();
            aliasName = dbHelper.getInfo("SELECT AliasName FROM teacher_master WHERE EmailId='" + user + "'");
            string dep = dbHelper.getInfo("SELECT Department FROM teacher_master WHERE EmailId='" + user + "'");
            lbWelcome.Text = "Welcome, " + aliasName + " | " + dep;
            lbLoginTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbDepartment.Text = dep;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.Yes)
            {
                this.Hide();
                Form1 obj = new Form1();
                obj.Show();
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            if (cmbYear.Items.Count > 0)
            {
                cmbYear.Items.Clear();
            }
            cmbYear.Items.Add("SELECT");
            dbHelper.fillCombo("SELECT AcademicYear FROM year_master", cmbYear);
            cmbYear.SelectedIndex = 0;
        }
        private string getTeacherName(String input)
        {
            string pattern = @"\(([^)]+)\)";

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                string extractedText = match.Groups[1].Value;
                return extractedText;
            }
            else
            {
                return "";
            }
        }
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex == 0) return;
            if (gridTimetableList.Rows.Count > 0)
            {
                gridTimetableList.Rows.Clear();
            }
            string holiday = dbHelper.getInfo("SELECT HolidaySchedule FROM semester_ciriculum WHERE AcademicYear='" + cmbYear.Text + "'");
            for (int i = 0; i < 7; i++)
            {
                if (days[i] == holiday)
                    gridTimetableList.Rows.Add(days[i], "", "", "", "", "", "", "", "");
                else
                    gridTimetableList.Rows.Add(days[i], "", "", "", "RECESS", "", "", "", "");

            }
            foreach (DataGridViewRow row in gridTimetableList.Rows)
            {
                if (row.Cells[0].Value.ToString() == holiday)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
            for (int i = 0; i < gridTimetableList.RowCount; i++)
            {
                gridTimetableList.Rows[i].Cells[4].Style.BackColor = Color.Red;
                gridTimetableList.Rows[i].Cells[4].Style.ForeColor = Color.White;
            }
            ArrayList result = dbHelper.getInfo11("SELECT Day,ClassName,First FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND First LIKE '%" + aliasName + "%'");

            foreach (String str in result)
            {
                String[] temp = str.Split("/");
                String day = temp[0], className = temp[1], subjectName = temp[2], subjectType = temp[3].Trim().Trim();
                foreach (DataGridViewRow row in gridTimetableList.Rows)
                {

                    if (row.Cells[0].Value.ToString().ToLower() == day.ToLower())
                    {
                        row.Cells[1].Value = className + "/" + subjectName + "(" + subjectType + ")";
                    }
                }
            }
            result = dbHelper.getInfo11("SELECT Day,ClassName,Second FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND Second LIKE '%" + aliasName + "%'");

            foreach (String str in result)
            {

                String[] temp = str.Split("/");
                String day = temp[0], className = temp[1], subjectName = temp[2], subjectType = temp[3].Trim();
                foreach (DataGridViewRow row in gridTimetableList.Rows)
                {

                    if (row.Cells[0].Value.ToString().ToLower() == day.ToLower())
                    {
                        row.Cells[2].Value = className + "/" + subjectName + "(" + subjectType + ")"; ;
                    }
                }
            }
            result = dbHelper.getInfo11("SELECT Day,ClassName,Third FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND Third LIKE '%" + aliasName + "%'");

            foreach (String str in result)
            {

                String[] temp = str.Split("/");
                String day = temp[0], className = temp[1], subjectName = temp[2], subjectType = temp[3].Trim();
                foreach (DataGridViewRow row in gridTimetableList.Rows)
                {

                    if (row.Cells[0].Value.ToString().ToLower() == day.ToLower())
                    {
                        row.Cells[3].Value = className + "/" + subjectName + "(" + subjectType + ")"; ;
                    }
                }
            }
            result = dbHelper.getInfo11("SELECT Day,ClassName,Fifth FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND Fifth LIKE '%" + aliasName + "%'");

            foreach (String str in result)
            {

                String[] temp = str.Split("/");
                String day = temp[0], className = temp[1], subjectName = temp[2], subjectType = temp[3].Trim();
                // MessageBox.Show(str);
                foreach (DataGridViewRow row in gridTimetableList.Rows)
                {

                    if (row.Cells[0].Value.ToString().ToLower() == day.ToLower())
                    {
                        row.Cells[5].Value = className + "/" + subjectName + "(" + subjectType + ")"; ;
                    }
                }
            }
            result = dbHelper.getInfo11("SELECT Day,ClassName,Sixth FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND Sixth LIKE '%" + aliasName + "%'");

            foreach (String str in result)
            {

                String[] temp = str.Split("/");
                String day = temp[0], className = temp[1], subjectName = temp[2], subjectType = temp[3].Trim();
                foreach (DataGridViewRow row in gridTimetableList.Rows)
                {

                    if (row.Cells[0].Value.ToString().ToLower() == day.ToLower())
                    {
                        row.Cells[6].Value = className + "/" + subjectName + "(" + subjectType + ")"; ;
                    }
                }
            }

            result = dbHelper.getInfo11("SELECT Day,ClassName,Seventh FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND Seventh LIKE '%" + aliasName + "%'");

            foreach (String str in result)
            {

                String[] temp = str.Split("/");
                String day = temp[0], className = temp[1], subjectName = temp[2], subjectType = temp[3].Trim();
                foreach (DataGridViewRow row in gridTimetableList.Rows)
                {

                    if (row.Cells[0].Value.ToString().ToLower() == day.ToLower())
                    {
                        row.Cells[7].Value = className + "/" + subjectName + "(" + subjectType + ")"; ;
                    }
                }
            }

        }
    }
}
