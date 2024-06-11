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
    public partial class AddSubject : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        string subStatus = "", status = "";
        int subjectNo = 0, subRowIndex = 0,totalHours=0;
        public AddSubject()
        {
            InitializeComponent();
        }
        public AddSubject(string dep)
        {
            InitializeComponent();
            lbDepartment.Text = dep;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HODForm form = (HODForm)this.ParentForm;
            form.panelContainer.Controls.Clear();
        }
        private void actionButtonNormalStage()
        {
            btnAddSub.Enabled = false;
            btnCacnelSub.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void actionButtonEditStage()
        {
            btnAddSub.Enabled = false;
            btnCacnelSub.Enabled = false;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void unlockAll(bool b)
        {
            cmbClass.Enabled = b;
            cmbSemester.Enabled = b;
            cmbTeacher.Enabled = b;
            cmbType.Enabled = b;
            cmbYear.Enabled = b;
            txtCode.Enabled = b;
            txtHours.Enabled = b;
            txtName.Enabled = b;
        }
        private void clear()
        {
            subjectNo = 0;
            txtName.Text = "";
            txtHours.Text = "0";
            lbDurationLeft.Text = "";
            txtCode.Text = "";
            if(gridClassSubjectList.Rows.Count > 0)
            {
                gridClassSubjectList.Rows.Clear();
            }
            if (cmbYear.Items.Count > 0)
            {
                cmbYear.Items.Clear();
            }
            cmbYear.Items.Add("SELECT");
            dbHelper.fillCombo("SELECT AcademicYear FROM year_master", cmbYear);
            cmbYear.SelectedIndex = 0;
            if (cmbSemester.Items.Count > 0)
            {
                cmbSemester.Items.Clear();
            }
            if (cmbClass.Items.Count > 0)
            {
                cmbClass.Items.Clear();
            }
            if (cmbTeacher.Items.Count > 0) cmbTeacher.Items.Clear();
            cmbTeacher.Items.Add("SELECT");
            dbHelper.fillCombo("SELECT AliasName FROM teacher_master WHERE Department='" + lbDepartment.Text + "'", cmbTeacher);
            cmbTeacher.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
        }
        private void AddSubject_Load(object sender, EventArgs e)
        {
            clear();
            unlockAll(false);
            actionButtonNormalStage();
            fillgrid();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbSemester.Items.Count > 0)
            {
                cmbSemester.Items.Clear();
            }
            cmbSemester.Items.Add("SELECT");
            dbHelper.fillCombo("SELECT SemesterName FROM semester_master WHERE AcademicYear='" + cmbYear.Text + "'", cmbSemester);
            if (status == "show") return;
            cmbSemester.SelectedIndex = 0;
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbClass.Items.Count > 0)
            {
                cmbClass.Items.Clear();
            }
            cmbClass.Items.Add("SELECT");
            dbHelper.fillCombo("SELECT ClassName FROM class_master WHERE Year='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "'", cmbClass);
            if (status == "show")
            {
                totalHours = Int32.Parse(dbHelper.getInfo("SELECT NoOfHours FROM semester_master WHERE SemesterName='" + cmbSemester.Text + "' AND AcademicYear='" + cmbYear.Text + "'"));
                int assignedHours = 0;
                foreach(DataGridViewRow row in gridClassSubjectList.Rows)
                {
                    assignedHours +=Int32.Parse(row.Cells["NoOfHours"].Value.ToString());
                }
                lbDurationLeft.Text=(totalHours-assignedHours).ToString()+" hrs left";
                return;
            }
            cmbClass.SelectedIndex = 0;
            if (cmbSemester.SelectedIndex == 0) lbDurationLeft.Text = "";
            else
            {
                totalHours = Int32.Parse(dbHelper.getInfo("SELECT NoOfHours FROM semester_master WHERE SemesterName='" + cmbSemester.Text + "' AND AcademicYear='" + cmbYear.Text + "'"));
                lbDurationLeft.Text = totalHours.ToString() + " hrs left";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
            unlockAll(true);
            actionButtonEditStage();
            btnAddSub.Enabled = true;
            btnCacnelSub.Enabled = true;
            subStatus = "Add New";
            status = "Add New";
            
        }
        private void clearSubjectFields()
        {
            txtCode.Text = "";
            txtName.Text = "";
            cmbTeacher.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            txtHours.Text = "0";
            lbDurationLeft.Text= totalHours.ToString() + " hrs left";
        }
        private void fillgrid()
        {
            dbHelper.show("SELECT * FROM subject_master", gridSubjectList);
            gridSubjectList.ClearSelection();
            gridClassSubjectList.CurrentCell = null;
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            int theoryCount = 0, labCount = 0;
            foreach (DataGridViewRow row in gridClassSubjectList.Rows)
            {
                string? subjectType = row.Cells[3].Value.ToString();
                if (subjectType == "Theory")
                {
                    theoryCount++;
                }
                else if (subjectType == "Lab")
                {
                    labCount++;
                }
            }
            if (theoryCount == 6 && cmbType.SelectedIndex == 1)
            {
                MessageBox.Show("Theory subject limit reached !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (labCount == 3 && cmbType.SelectedIndex == 2)
            {
                MessageBox.Show("Lab subject limit reached !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (subStatus == "Add New")
            {
                if (gridClassSubjectList.Rows.Count >= 9)
                {
                    clearSubjectFields();
                    MessageBox.Show("Only 9 subjects can be added for one class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtCode.Text == "" || txtName.Text == "" || cmbTeacher.SelectedIndex == 0 || cmbType.SelectedIndex == 0 || txtHours.Text == "0")
                {
                    MessageBox.Show("Enter all fields !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult drs = MessageBox.Show("Are you sure do you want to add this subject?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                subjectNo += 1;
                gridClassSubjectList.Rows.Add(subjectNo, txtName.Text, txtCode.Text, cmbType.Text, cmbTeacher.Text, txtHours.Text, "Edit", "Delete");
                gridClassSubjectList.ClearSelection();
                totalHours-=Int32.Parse(txtHours.Text);
            }
            else if (subStatus == "edit")
            {
                if (txtCode.Text == "" || txtName.Text == "" || cmbTeacher.SelectedIndex == 0 || cmbType.SelectedIndex == 0 || txtHours.Text == "")
                {
                    MessageBox.Show("Enter all fields !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult drs = MessageBox.Show("Are you sure do you want to update this subject?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                gridClassSubjectList.Rows[subRowIndex].Cells[1].Value = txtName.Text;
                gridClassSubjectList.Rows[subRowIndex].Cells[2].Value = txtCode.Text;
                gridClassSubjectList.Rows[subRowIndex].Cells[3].Value = cmbType.Text;
                gridClassSubjectList.Rows[subRowIndex].Cells[4].Value = cmbTeacher.Text;
                gridClassSubjectList.Rows[subRowIndex].Cells[5].Value = txtHours.Text;
                gridClassSubjectList.Rows[subRowIndex].Cells[6].Value = "Edit";
                gridClassSubjectList.Rows[subRowIndex].Cells[7].Value = "Delete";
                gridClassSubjectList.ClearSelection();
                subStatus = "Add New";
                btnAddSub.Text = "Add Subject";
            }
            clearSubjectFields();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridClassSubjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                txtCode.Text = gridClassSubjectList.CurrentRow.Cells[2].Value.ToString();
                txtName.Text = gridClassSubjectList.CurrentRow.Cells[1].Value.ToString();
                cmbType.Text = gridClassSubjectList.CurrentRow.Cells[3].Value.ToString();
                cmbTeacher.Text = gridClassSubjectList.CurrentRow.Cells[4].Value.ToString();
                subStatus = "edit";
                subRowIndex = e.RowIndex;
                btnAddSub.Text = "Update Subject";
            }
            else if (e.ColumnIndex == 7)
            {
                clearSubjectFields();
                DialogResult drs = MessageBox.Show("Are you sure do you want to delete this subject?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                gridClassSubjectList.Rows.RemoveAt(e.RowIndex);
                int srno = 0;
                for (int i = 0; i < gridClassSubjectList.Rows.Count; i++)
                {
                    srno++;
                    gridClassSubjectList.Rows[0].SetValues(srno.ToString());
                }
            }
            gridClassSubjectList.ClearSelection();
        }

        private void btnCacnelSub_Click(object sender, EventArgs e)
        {
            clearSubjectFields();
            gridClassSubjectList.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "Add New")
            {
                if (gridClassSubjectList.Rows.Count != 9 || cmbYear.SelectedIndex == 0 || cmbSemester.SelectedIndex == 0 || cmbClass.SelectedIndex == 0)
                {
                    if (gridClassSubjectList.Rows.Count != 9)
                    {
                        MessageBox.Show("Atleast 9 subjects required !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cmbYear.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select academic year !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cmbSemester.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select semester !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cmbClass.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select class !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                int count = Int32.Parse(dbHelper.getInfo("SELECT COUNT(*) FROM subject_master WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND SemesterName='" + cmbSemester.Text + "' AND ClassName='" + cmbClass.Text + "'"));
                if (count == 1)
                {
                    MessageBox.Show("Subjects already exists for the class " + cmbClass.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult drs = MessageBox.Show("Are you sure do you want to add this class subjects?", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                int subjectNo = dbHelper.getSrNo("SELECT MAX(SubjectNo) FROM subject_master");
                bool result = dbHelper.TableOperation("INSERT INTO subject_master VALUES(" + subjectNo + ",'" + cmbYear.Text + "','" + lbDepartment.Text + "','" + cmbSemester.Text + "','" + cmbClass.Text + "');");
                if (result)
                {
                    bool res1 = false;
                    for (int i = 0; i < gridClassSubjectList.Rows.Count; i++)
                    {
                        string? subjectName = gridClassSubjectList.Rows[i].Cells[1].Value.ToString();
                        string? subjectCode = gridClassSubjectList.Rows[i].Cells[2].Value.ToString();
                        string? subjectType = gridClassSubjectList.Rows[i].Cells[3].Value.ToString();
                        string? teacher = gridClassSubjectList.Rows[i].Cells[4].Value.ToString();
                        string? duration = gridClassSubjectList.Rows[i].Cells[5].Value.ToString();
                        res1 = dbHelper.TableOperation("INSERT INTO class_subjects VALUES(" + subjectNo + ",'" + subjectCode + "','" + subjectName + "','" + subjectType + "','" + teacher + "','" + duration + "');");
                        if (!res1)
                        {
                            MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dbHelper.TableOperation("DELETE FROM subject_master WHERE SrNo=" + subjectNo);
                            break;
                        }
                    }
                    if (res1)
                    {
                        MessageBox.Show("Subjects added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            clear();
            unlockAll(false);
            actionButtonNormalStage();
            fillgrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            unlockAll(false);
            actionButtonNormalStage();
            fillgrid();
        }

        private void gridSubjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            status = "show";
            int subjectNo = Int32.Parse(gridSubjectList.CurrentRow.Cells[0].Value.ToString());
            if (gridClassSubjectList.Rows.Count > 0) gridClassSubjectList.Rows.Clear();
            dbHelper.addSubjects("SELECT * FROM class_subjects WHERE SubjectNo=" + subjectNo, gridClassSubjectList);
            int srno = 0;
            foreach (DataGridViewRow row in gridClassSubjectList.Rows)
            {
                srno++;
                row.Cells[0].Value = srno;
            }
            cmbYear.Text = gridSubjectList.CurrentRow.Cells[1].Value.ToString();
            cmbSemester.Text = gridSubjectList.CurrentRow.Cells[3].Value.ToString();
            cmbClass.Text = gridSubjectList.CurrentRow.Cells[4].Value.ToString();
            actionButtonEditStage();
            
        }
    }
}
