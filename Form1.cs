using System.Windows.Forms;

namespace AutomatedTimeTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("d");
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Are you sure do you want exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel4.Size == panel4.MinimumSize)
            {
                panel4.Size = panel4.MaximumSize;
                pictureBox3.Image = Properties.Resources.arrow_up;
            }
            else
            {
                panel4.Size = panel4.MinimumSize;
                pictureBox3.Image = Properties.Resources.arrow_down;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (panel7.Size == panel7.MinimumSize)
            {
                panel7.Size = panel7.MaximumSize;
                pictureBox4.Image = Properties.Resources.arrow_up;
            }
            else
            {
                panel7.Size = panel7.MinimumSize;
                pictureBox4.Image = Properties.Resources.arrow_down;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panel9.Size == panel9.MinimumSize)
            {
                panel9.Size = panel9.MaximumSize;
                pictureBox6.Image = Properties.Resources.arrow_up;
            }
            else
            {
                panel9.Size = panel9.MinimumSize;
                pictureBox6.Image = Properties.Resources.arrow_down;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (panel12.Size == panel12.MinimumSize)
            {
                panel12.Size = panel12.MaximumSize;
                pictureBox8.Image = Properties.Resources.arrow_up;
            }
            else
            {
                panel12.Size = panel12.MinimumSize;
                pictureBox8.Image = Properties.Resources.arrow_down;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void clearConainer()
        {
            if (panelContainer.Controls.Count > 0)
            {
                panelContainer.Controls.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearConainer();
            Adminlogin adminlogin = new Adminlogin();
            panelContainer.Controls.Add(adminlogin);
            Rectangle parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Left = (parentRect.Width - adminlogin.Width) / 2;
            parentRect = adminlogin.Parent.ClientRectangle;
            adminlogin.Top = (parentRect.Height - adminlogin.Height) / 2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearConainer();
            HODLogin teacherlogin = new HODLogin();
            panelContainer.Controls.Add(teacherlogin);
            Rectangle parentRect = teacherlogin.Parent.ClientRectangle;
            teacherlogin.Left = (parentRect.Width - teacherlogin.Width) / 2;
            parentRect = teacherlogin.Parent.ClientRectangle;
            teacherlogin.Top = (parentRect.Height - teacherlogin.Height) / 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearConainer();
            TeacherLogin teacherlogin = new TeacherLogin();
            panelContainer.Controls.Add(teacherlogin);
            Rectangle parentRect = teacherlogin.Parent.ClientRectangle;
            teacherlogin.Left = (parentRect.Width - teacherlogin.Width) / 2;
            parentRect = teacherlogin.Parent.ClientRectangle;
            teacherlogin.Top = (parentRect.Height - teacherlogin.Height) / 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearConainer();
            StudentPanel teacherlogin = new StudentPanel();
            panelContainer.Controls.Add(teacherlogin);
            teacherlogin.Dock = DockStyle.Fill;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}