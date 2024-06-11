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
    public partial class StudentPanel : UserControl
    {
        Db_Helper db_Helper = new Db_Helper();
        public StudentPanel()
        {
            InitializeComponent();
        }
        public StudentPanel(string data)
        {
            InitializeComponent();
            label1.Text = data;
        }

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            cmbDepartment.SelectedIndex = 0;
            if (cmbYear.Items.Count > 0)
            {
                cmbYear.Items.Clear();
            }
            cmbYear.Items.Add("SELECT");
            db_Helper.fillCombo("SELECT AcademicYear FROM year_master", cmbYear);
            cmbYear.SelectedIndex = 0;
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex == 0) { return; }
            if (cmbSemesterName.Items.Count > 0)
            {
                cmbSemesterName.Items.Clear();
            }
            cmbSemesterName.Items.Add("SELECT");
            db_Helper.fillCombo("SELECT SemesterName FROM semester_master WHERE AcademicYear='" + cmbYear.Text + "'", cmbSemesterName);
            cmbSemesterName.SelectedIndex = 0;
        }

        private void cmbSemesterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemesterName.SelectedIndex == 0) return;
            if (cmbClassName.Items.Count > 0)
            {
                cmbClassName.Items.Clear();
            }
            cmbClassName.Items.Add("SELECT");
            db_Helper.fillCombo("SELECT ClassName FROM class_master WHERE Year='" + cmbYear.Text + "' AND Department='" + cmbDepartment.Text + "'", cmbClassName);

            cmbClassName.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string holiday = db_Helper.getInfo("SELECT HolidaySchedule FROM semester_ciriculum WHERE Department='" + cmbDepartment.Text + "' AND SemesterName='" + cmbSemesterName.Text + "' AND AcademicYear='" + cmbYear.Text + "'");
            db_Helper.showTimetable("SELECT Day,First,Second,Third,Fourth,Fifth,Sixth,Seventh FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + cmbDepartment.Text + "' AND SemesterName='" + cmbSemesterName.Text + "' AND ClassName='" + cmbClassName.Text + "'", gridTimeTableList);
            foreach (DataGridViewRow row in gridTimeTableList.Rows)
            {
                //MessageBox.Show(row.Cells[0].Value);
                if (row.Cells[0].Value.ToString() == holiday)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;

                }
                else
                {
                    row.Cells[4].Value = "RECESS";
                    row.Cells[4].Style.BackColor = Color.Red;
                    row.Cells[4].Style.ForeColor = Color.White;
                }
            }
        }
    }
}
