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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult drs;
            drs = MessageBox.Show("Are you sure do you want to Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.No)
            {
                return;
            }
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }
        private void clearContainer()
        {
            if (panelContainer.Controls.Count > 0)
            {
                panelContainer.Controls.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearContainer();
            addYear adminlogin = new addYear();
            panelContainer.Controls.Add(adminlogin);
            Rectangle parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Left = (parentRect.Width - adminlogin.Width) / 2;
            parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Top = (parentRect.Height - adminlogin.Height) / 2;
            adminlogin.clear();
            adminlogin.actionButtonNormalStage();
            adminlogin.unlockAll(false);
            adminlogin.fillgrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearContainer();
            Addclass adminlogin = new Addclass();
            panelContainer.Controls.Add(adminlogin);
            Rectangle parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Left = (parentRect.Width - adminlogin.Width) / 2;
            parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Top = (parentRect.Height - adminlogin.Height) / 2;
            adminlogin.clear();
            adminlogin.actionButtonNormalStage();
            adminlogin.unlockAll(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearContainer();
            Semester adminlogin = new Semester();
            panelContainer.Controls.Add(adminlogin);
            Rectangle parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Left = (parentRect.Width - adminlogin.Width) / 2;
            parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Top = (parentRect.Height - adminlogin.Height) / 2;
            adminlogin.clear();
            adminlogin.actionButtonNormalStage();
            adminlogin.unlockAll(false);
            adminlogin.fillgrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearContainer();
            Teachers adminlogin = new Teachers();
            panelContainer.Controls.Add(adminlogin);
            Rectangle parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Left = (parentRect.Width - adminlogin.Width) / 2;
            parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Top = (parentRect.Height - adminlogin.Height) / 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearContainer();
            StudentPanel teacherlogin = new StudentPanel("Time Table Section");
            panelContainer.Controls.Add(teacherlogin);
            teacherlogin.Dock = DockStyle.Fill;
        }
    }
}
