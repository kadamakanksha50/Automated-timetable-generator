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
    public partial class ViewUserControl : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        string query = "";
        public ViewUserControl()
        {
            InitializeComponent();
        }
        public ViewUserControl(string title, Color color, string query)
        {
            InitializeComponent();
            label1.Text = title;
            panel1.BackColor = color;
            panel2.BackColor = color;
            this.query = query;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HODForm form = (HODForm)this.ParentForm;
            form.panelContainer.Controls.Clear();
        }

        private void ViewUserControl_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
            dbHelper.show(query, dataGridView1);
            label3.Text = "No Of Records : " + dataGridView1.Rows.Count;
            dataGridView1.CurrentCell = null;
            dataGridView1.ClearSelection();
        }
    }
}
