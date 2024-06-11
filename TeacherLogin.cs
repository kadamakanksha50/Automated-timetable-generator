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
    public partial class TeacherLogin : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        public TeacherLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuser.Text=="" || txtpwd.Text == "")
            {
                MessageBox.Show("Please enter credentails to login !!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            bool res = dbHelper.validateLogin("SELECT * FROM teachers_login WHERE Username='"+txtuser.Text+"' AND Password='"+txtpwd.Text+"' AND Role!='HOD'");
            if(res)
            {
                TeacherForm teacherForm = new TeacherForm(txtuser.Text);
                teacherForm.Show();
                Form1 parent = (Form1)this.ParentForm;
                parent.Hide();
            }
            else
            {
                MessageBox.Show("Login failed !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpwd.Clear();
                txtuser.Clear();
                txtuser.Focus();
            }
        }
    }
}
