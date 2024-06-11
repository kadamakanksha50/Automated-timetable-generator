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
    public partial class Adminlogin : UserControl
    {
        
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin@project.com" && textBox2.Text == "Admin@123")
            {
                var parentForm = this.ParentForm;
                AdminForm obj = new AdminForm();                
                parentForm.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Login faild !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
