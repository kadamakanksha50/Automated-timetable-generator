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
    public partial class HODLogin : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        public HODLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter login credentials !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtPassword.Text == string.Empty)
                {
                    txtPassword.Focus();
                }
                if (txtUsername.Text == string.Empty)
                {
                    txtUsername.Focus();
                }
            }
            else
            {
                bool res = dbHelper.validateLogin("SELECT Username,Password FROM teachers_login WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'");
                if (res)
                {
                    HODForm form = new HODForm(txtUsername.Text, DateTime.Now.ToString("hh:mm:ss tt"));
                    form.Show();
                    Form1 parent = (Form1)this.ParentForm;
                    parent.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }
    }
}
