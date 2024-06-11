using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomatedTimeTable
{
    public partial class Teachers : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        string status = "";
        string uploadPath = "";
        int teacherSrNo = 0;

        public Teachers()
        {
            InitializeComponent();
        }
        public void clear()
        {
            lbTeacherCode.Text = "";
            txtAdd.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtMob.Text = "";
            cmbAssign.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
            cmbQual.SelectedIndex = 0;
            cmbTitle.SelectedIndex = 0;
            pictureBox1.Image = Properties.Resources.teacher;
            panelHod.Visible = false;
            panelClassTeacher.Visible = false;
            lbAliasName.Text = "";
        }
        public void unlockAll(bool b)
        {
            txtAdd.Enabled = b;
            txtEmail.Enabled = b;
            txtFirstName.Enabled = b;
            txtLastName.Enabled = b;
            txtMiddleName.Enabled = b;
            txtMob.Enabled = b;
            cmbAssign.Enabled = b;
            cmbDepartment.Enabled = b;
            cmbQual.Enabled = b;
            cmbTitle.Enabled = b;
            txtPassword.Enabled = b;
            txtUsername.Enabled = false;
            cmbAssignClassName.Enabled = b;
            cmbHODDep.Enabled = b;
        }
        public void actionButtonNormalStage()
        {
            btnBrowse.Enabled = false;
            btnNew.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
        }
        public void actionButtonEditStage()
        {
            btnBrowse.Enabled = true;
            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
        }
        private void Teachers_Load(object sender, EventArgs e)
        {
            clear();
            unlockAll(false);
            actionButtonNormalStage();
            fillgrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HODForm form = (HODForm)this.ParentForm;
            form.panelContainer.Controls.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            unlockAll(true);
            actionButtonEditStage();
            status = "Add New";
            teacherSrNo = dbHelper.getSrNo("SELECT MAX(SrNo) FROM teacher_master");
            lbTeacherCode.Text = "TCHR-00" + teacherSrNo.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            status = "Update";
            actionButtonEditStage();
            unlockAll(false);
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to delete this teacher?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.No) { return; }
            String query = "DELETE FROM teacher_master  WHERE Code='" + lbTeacherCode.Text + "';";
            bool res = dbHelper.TableOperation(query);
            if (res)
            {
                MessageBox.Show("Teacher deleted successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            unlockAll(false);
            clear();
            status = "";
            actionButtonNormalStage();
            fillgrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "Add New")
            {
                DialogResult drs = MessageBox.Show("Are you sure do you want to add this teacher?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                String query = "INSERT INTO teacher_master VALUES('" + lbTeacherCode.Text + "','" + cmbTitle.Text + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "','" + lbAliasName.Text + "','" + cmbDepartment.Text + "','" + cmbQual.Text + "','" + txtMob.Text + "','" + txtEmail.Text + "','" + txtAdd.Text + "','" + cmbAssign.Text + "'," + teacherSrNo + ",'" + uploadPath + "');";
                bool res = dbHelper.TableOperation(query);
                bool res1 = false, res2 = false, res3 = false, res4 = false;
                if (cmbAssign.SelectedIndex == 1)
                {
                    res1 = dbHelper.TableOperation("INSERT INTO class_teachers VALUES('" + lbAliasName.Text + "','" + cmbAssignClassName.Text + "')");
                    res4 = dbHelper.TableOperation("INSERT INTO teachers_login VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbDepartment.Text + "','Class Teacher')");
                    if (res && res1 && res4)
                    {
                        MessageBox.Show("Teacher added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cmbAssign.SelectedIndex == 2)
                {
                    res2 = dbHelper.TableOperation("INSERT INTO teachers_login VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbDepartment.Text + "','HOD')");
                    if (res && res2)
                    {
                        MessageBox.Show("Teacher added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cmbAssign.SelectedIndex == 3)
                {
                    res3 = dbHelper.TableOperation("INSERT INTO teachers_login VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbDepartment.Text + "','Facutly')");
                    if (res && res3)
                    {
                        MessageBox.Show("Teacher added successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (status == "Update")
            {
                DialogResult drs = MessageBox.Show("Are you sure do you want to update this teacher?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.No) { return; }
                String query = "UPDATE teacher_master SET Title='" + cmbTitle.Text + "',FirstName='" + txtFirstName.Text + "',MiddleName='" + txtMiddleName.Text + "',LastName='" + txtLastName.Text + "',AliasName='" + lbAliasName.Text + "',Department='" + cmbDepartment.Text + "',Qualification='" + cmbQual.Text + "',MobileNo='" + txtMob.Text + "',EmailId='" + txtEmail.Text + "',Address='" + txtAdd.Text + "',AssignTo='" + cmbAssign.Text + "',ImagePath='" + uploadPath + "' WHERE Code='" + lbTeacherCode.Text + "';";
                bool res = dbHelper.TableOperation(query);
                if (res)
                {
                    MessageBox.Show("Teacher updated successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            unlockAll(false);
            clear();
            status = "";
            actionButtonNormalStage();
            fillgrid();

        }
        private void fillgrid()
        {
            if (gridTeacherList.Rows.Count > 0)
            {
                gridTeacherList.DataSource = null;
                gridTeacherList.Rows.Clear();
            }
            dbHelper.show("SELECT Code,AliasName as TeacherName,Department,Qualification,MobileNo,EmailId,Address,AssignTo FROM teacher_master ORDER BY Code", gridTeacherList);
            gridTeacherList.ClearSelection();
            gridTeacherList.CurrentCell = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            unlockAll(false);
            clear();
            status = "";
            actionButtonNormalStage();
            fillgrid();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status == "fill")
            {
                if (cmbAssign.SelectedIndex == 1)
                {
                    panelHod.Visible = false;
                    panelClassTeacher.Visible = true;
                    panelClassTeacher.BringToFront();
                    cmbHODDep.Text = cmbDepartment.Text;
                }
                else if (cmbAssign.SelectedIndex == 2)
                {
                    panelClassTeacher.Visible = false;
                    panelHod.Visible = true;
                    panelHod.BringToFront();
                }
                return;
            }
            if (cmbAssign.SelectedIndex == 1)
            {
                panelHod.Visible = false;
                panelClassTeacher.Visible = true;
                panelClassTeacher.BringToFront();
                cmbHODDep.Text = cmbDepartment.Text;
            }
            else if (cmbAssign.SelectedIndex == 2)
            {
                panelClassTeacher.Visible = false;
                panelHod.Visible = true;
                panelHod.BringToFront();
                if (cmbAssignClassName.Items.Count > 0)
                {
                    cmbAssignClassName.Items.Clear();
                }
                cmbAssignClassName.Items.Add("SELECT CLASS");
                dbHelper.fillCombo("SELECT ClassName FROM class_master WHERE Department='" + cmbDepartment.Text + "'", cmbAssignClassName);
                cmbAssignClassName.SelectedIndex = 0;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    pictureBox1.ImageLocation = selectedFilePath;
                }
                if (pictureBox1.Image != null)
                {
                    string projectFolderPath = AppDomain.CurrentDomain.BaseDirectory;
                    string uploadFolderPath = Path.Combine(projectFolderPath, "UploadedPhotos");

                    if (!Directory.Exists(uploadFolderPath))
                    {
                        Directory.CreateDirectory(uploadFolderPath);
                    }

                    string selectedFileName = Path.GetFileName(pictureBox1.ImageLocation);
                    string destinationFilePath = Path.Combine(uploadFolderPath, selectedFileName);
                    uploadPath = "UploadedPhotos/" + selectedFileName;
                    File.Copy(pictureBox1.ImageLocation, destinationFilePath, true);


                }
                else
                {
                    MessageBox.Show("Please select a photo to upload.", "No Photo Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            setAliasName();

        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            setAliasName();
        }
        private void setAliasName()
        {
            string first = txtFirstName.Text.Length > 0 ? txtFirstName.Text[0].ToString() : string.Empty;
            string second = txtMiddleName.Text.Length > 0 ? txtMiddleName.Text[0].ToString() : string.Empty;
            string dignity = "";
            if (cmbTitle.SelectedIndex == 1)
            {
                dignity = "Sir";
            }
            else if (cmbTitle.SelectedIndex > 1 && cmbTitle.SelectedIndex <= 3)
            {
                dignity = "Mam";
            }
            lbAliasName.Text = first + "." + second + "." + txtLastName.Text + " " + dignity;
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            setAliasName();
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            setAliasName();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtEmail.Text;
        }

        private void gridTeacherList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTeacherList.CurrentRow == null) return;
            status = "fill";
            lbTeacherCode.Text = gridTeacherList.CurrentRow.Cells[0].Value.ToString();
            lbAliasName.Text = gridTeacherList.CurrentRow.Cells[1].Value.ToString();
            cmbDepartment.Text = gridTeacherList.CurrentRow.Cells[2].Value.ToString();
            cmbQual.Text = gridTeacherList.CurrentRow.Cells[3].Value.ToString();
            txtMob.Text = gridTeacherList.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = gridTeacherList.CurrentRow.Cells[5].Value.ToString();
            txtAdd.Text = gridTeacherList.CurrentRow.Cells[6].Value.ToString();
            cmbAssign.Text = gridTeacherList.CurrentRow.Cells[7].Value.ToString();
            uploadPath = dbHelper.getInfo("Select ImagePath from teacher_master WHERE Code='" + lbTeacherCode.Text + "'");
            txtFirstName.Text = dbHelper.getInfo("Select FirstName from teacher_master WHERE Code='" + lbTeacherCode.Text + "'");
            txtMiddleName.Text = dbHelper.getInfo("Select MiddleName from teacher_master WHERE Code='" + lbTeacherCode.Text + "'");
            txtLastName.Text = dbHelper.getInfo("Select LastName from teacher_master WHERE Code='" + lbTeacherCode.Text + "'");
            cmbTitle.Text = dbHelper.getInfo("Select Title from teacher_master WHERE Code='" + lbTeacherCode.Text + "'");
            txtPassword.Text = dbHelper.getInfo("Select Password from teachers_login WHERE Username='" + txtUsername.Text + "'");
            string projectFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            if (uploadPath != "") pictureBox1.ImageLocation = projectFolderPath + uploadPath;
            cmbAssignClassName.Items.Add(dbHelper.getInfo("Select ClassName from class_teachers WHERE TeacherName='" + lbAliasName.Text + "'"));
            cmbAssignClassName.SelectedIndex = 0;
            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (gridTeacherList.Rows.Count > 0)
            {
                gridTeacherList.DataSource = null;
                gridTeacherList.Rows.Clear();
            }
            dbHelper.show("SELECT Code,AliasName as TeacherName,Department,Qualification,MobileNo,EmailId,Address,AssignTo FROM teacher_master WHERE AliasName LIKE '%" + textBox1.Text + "%' ORDER BY Code", gridTeacherList);
            gridTeacherList.ClearSelection();
            gridTeacherList.CurrentCell = null;
        }
    }
}
