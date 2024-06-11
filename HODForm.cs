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
    public partial class HODForm : Form
    {
        Db_Helper dbHelper = new Db_Helper();
        private int labelPositionX = 0;
        private string username = "";
        private string dep = "";
        public HODForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public HODForm(string username, string loginTime)
        {
            InitializeComponent();
            this.username = username;
            this.DoubleBuffered = true;
            lbLoginTime.Text = "Login Time : " + loginTime;
            lbWelcome.Text = "Welcome, " + dbHelper.getInfo("Select AliasName FROM teacher_master WHERE EmailId='" + username + "'");
            dep = dbHelper.getInfo("SELECT Department FROM teacher_master where EmailId='" + username + "'");
            lbDepartment.Text = "Head Of Department || " + dep;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.Yes)
            {
                this.Hide();
                Form1 obj1 = new Form1();
                obj1.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void HODForm_Load(object sender, EventArgs e)
        {
            labelPositionX = lbNote.Location.X;
            timer1.Start();
            this.DoubleBuffered = true;
            lbInstructions.Text = "Ready.";
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            if (panelContainer.Controls.Count == 0)
            {
                lbInstructions.Text = "Ready.";
            }
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
            ViewUserControl classes = new ViewUserControl("View Departmental Classes", button1.BackColor, "Select * from class_master WHERE Department='" + dep + "'");
            panelContainer.Controls.Add(classes);
            Rectangle parentRect = classes.Parent.ClientRectangle;
            classes.Left = (parentRect.Width - classes.Width) / 2;
            parentRect = classes.Parent.ClientRectangle;
            classes.Top = (parentRect.Height - classes.Height) / 2;
            lbInstructions.Text = "All these are departmental classes.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearContainer();
            ViewUserControl classes = new ViewUserControl("View Departmental Teachers", button2.BackColor, "SELECT Code,AliasName as TeacherName,Department,Qualification,MobileNo,EmailId,Address,AssignTo FROM teacher_master WHERE Department='" + dep + "' ORDER BY Code");
            panelContainer.Controls.Add(classes);
            Rectangle parentRect = classes.Parent.ClientRectangle;
            classes.Left = (parentRect.Width - classes.Width) / 2;
            parentRect = classes.Parent.ClientRectangle;
            classes.Top = (parentRect.Height - classes.Height) / 2;
            lbInstructions.Text = "All these are departmental teachers.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearContainer();
            SemesterCirculum classes = new SemesterCirculum(dep);
            panelContainer.Controls.Add(classes);
            Rectangle parentRect = classes.Parent.ClientRectangle;
            classes.Left = (parentRect.Width - classes.Width) / 2;
            parentRect = classes.Parent.ClientRectangle;
            classes.Top = (parentRect.Height - classes.Height) / 2;
            lbInstructions.Text = "Add or update your departmental ciriculum.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbInstructions.Text = "1. Every classes must have only 9 subjects. 2. Add your subjects with teachers and training hours.";
            clearContainer();
            AddSubject classes = new AddSubject(dep);
            panelContainer.Controls.Add(classes);
            Rectangle parentRect = classes.Parent.ClientRectangle;
            classes.Left = (parentRect.Width - classes.Width) / 2;
            parentRect = classes.Parent.ClientRectangle;
            classes.Top = (parentRect.Height - classes.Height) / 2;
        }

        private void panelContainer_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbInstructions.Text = "1. Every classes must have only 9 subjects. 2. Add your subjects with teachers and training hours.";
            clearContainer();
            TimeTable classes = new TimeTable(dep);
            panelContainer.Controls.Add(classes);
            Rectangle parentRect = classes.Parent.ClientRectangle;
            classes.Left = (parentRect.Width - classes.Width) / 2;
            parentRect = classes.Parent.ClientRectangle;
            classes.Top = (parentRect.Height - classes.Height) / 2;
        }
    }
}
