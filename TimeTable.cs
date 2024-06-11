using DGVPrinterHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedTimeTable
{
    public partial class TimeTable : UserControl
    {
        Db_Helper dbHelper = new Db_Helper();
        ArrayList labs = new ArrayList();
        ArrayList theory = new ArrayList();
        String holiday = "";
        public TimeTable()
        {
            InitializeComponent();
        }
        public TimeTable(string dep)
        {
            InitializeComponent();
            lbDepartment.Text = dep;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HODForm form = (HODForm)this.ParentForm;
            form.panelContainer.Controls.Clear();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            gridTimetableList.Rows.Add("Monday");
            gridTimetableList.Rows.Add("Tuesday");
            gridTimetableList.Rows.Add("Wednesday");
            gridTimetableList.Rows.Add("Thursday");
            gridTimetableList.Rows.Add("Friday");
            gridTimetableList.Rows.Add("Saturday");
            gridTimetableList.Rows.Add("Sunday");
            gridTimetableList.ClearSelection();
            if (cmbYear.Items.Count > 0)
            {
                cmbYear.Items.Clear();
            }
            cmbYear.Items.Add("SELECT");
            dbHelper.fillCombo("SELECT AcademicYear FROM year_master ORDER BY SrNo", cmbYear);
            cmbYear.SelectedIndex = 0;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gridTimetableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridTimetableList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void gridTimetableList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex == 0) { return; }
            if (cmbSemesterName.Items.Count > 0)
            {
                cmbSemesterName.Items.Clear();
            }
            cmbSemesterName.Items.Add("SELECT");
            dbHelper.fillCombo("SELECT SemesterName FROM semester_master WHERE AcademicYear='" + cmbYear.Text + "'", cmbSemesterName);
            cmbSemesterName.SelectedIndex = 0;
        }

        private void cmbSemesterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemesterName.SelectedIndex == 0) { return; }
            if (cmbClassName.Items.Count > 0)
            {
                cmbClassName.Items.Clear();
            }
            cmbClassName.Items.Add("SELECT");
            dbHelper.fillCombo("SELECT ClassName FROM class_master WHERE Year='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "'", cmbClassName);
            cmbClassName.SelectedIndex = 0;
            holiday = dbHelper.getInfo("SELECT HolidaySchedule FROM semester_ciriculum WHERE Department='" + lbDepartment.Text + "' AND SemesterName='" + cmbSemesterName.Text + "' AND AcademicYear='" + cmbYear.Text + "'");
            foreach (DataGridViewRow row in gridTimetableList.Rows)
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

        private void cmbClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClassName.SelectedIndex == 0) return;
            int count = Int32.Parse(dbHelper.getInfo("SELECT COUNT(*) FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND SemesterName='" + cmbSemesterName.Text + "' AND ClassName='" + cmbClassName.Text + "'"));

            if (count >= 1)
            {
                if (gridTimetableList.Rows.Count > 0)
                {
                    gridTimetableList.Rows.Clear();
                }
                dbHelper.showTimetable("SELECT Day,First,Second,Third,Fourth,Fifth,Sixth,Seventh FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND SemesterName='" + cmbSemesterName.Text + "' AND ClassName='" + cmbClassName.Text + "'", gridTimetableList);
                foreach (DataGridViewRow row in gridTimetableList.Rows)
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
                button1.Text = "Save And Download Timetable";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Save And Download Timetable")
            {
                int count = Int32.Parse(dbHelper.getInfo("SELECT COUNT(*) FROM timetable WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND SemesterName='" + cmbSemesterName.Text + "' AND ClassName='" + cmbClassName.Text + "'"));
                if (count >= 1)
                {
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "TimeTable";
                    printer.SubTitle = cmbClassName.Text + "(" + cmbYear.Text + ")";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Center;
                    printer.Footer = "Final Year Project";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(gridTimetableList);
                    MessageBox.Show("Timetable created successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HODForm form = (HODForm)this.ParentForm;
                    form.panelContainer.Controls.Clear();
                }
                else
                {
                    int srno = dbHelper.getSrNo("SELECT MAX(SrNo) FROM timetable");
                    //MessageBox.Show(srno.ToString());
                    bool status = false;
                    foreach (DataGridViewRow row in gridTimetableList.Rows)
                    {
                        string day, first, second, third, fourth, fifth, sixth, seventh;
                        if (row.DefaultCellStyle.BackColor == Color.Red)
                        {
                            day = row.Cells[0].Value.ToString();
                            first = "Holiday";
                            second = "Holiday";
                            third = "Holiday";
                            fourth = "Holiday";
                            fifth = "Holiday";
                            sixth = "Holiday";
                            seventh = "Holiday";
                        }
                        else
                        {
                            day = row.Cells[0].Value.ToString();
                            first = row.Cells[1].Value.ToString();
                            second = row.Cells[2].Value.ToString();
                            third = row.Cells[3].Value.ToString();
                            fourth = row.Cells[4].Value.ToString();
                            fifth = row.Cells[5].Value.ToString();
                            sixth = row.Cells[6].Value.ToString();
                            seventh = row.Cells[7].Value.ToString();
                        }


                        status = dbHelper.TableOperation("INSERT INTO timetable VALUES(" + srno + ",'" + cmbYear.Text + "','" + lbDepartment.Text + "','" + cmbSemesterName.Text + "','" + cmbClassName.Text + "','" + day + "','" + first + "','" + second + "','" + third + "','" + fourth + "','" + fifth + "','" + sixth + "','" + seventh + "'); ");
                        //   MessageBox.Show(status.ToString());
                        if (status == false)
                            break;
                    }
                    if (status == false)
                    {
                        dbHelper.TableOperation("DELETE FROM timetable WHERE SrNo=" + srno);
                    }
                    else
                    {
                        DGVPrinter printer = new DGVPrinter();
                        printer.Title = "TimeTable";
                        printer.SubTitle = cmbClassName.Text + "(" + cmbYear.Text + ")";
                        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                        printer.PageNumbers = true;
                        printer.PageNumberInHeader = false;
                        printer.PorportionalColumns = true;
                        printer.HeaderCellAlignment = StringAlignment.Center;
                        printer.Footer = "Final Year Project";
                        printer.FooterSpacing = 15;
                        printer.PrintDataGridView(gridTimetableList);
                        MessageBox.Show("Timetable created successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HODForm form = (HODForm)this.ParentForm;
                        form.panelContainer.Controls.Clear();
                    }
                }



                //if (gridTimetableList.Rows.Count > 0)
                //{
                //    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                //    MExcel.Application.Workbooks.Add(Type.Missing);
                //    for (int i = 1; i < gridTimetableList.Columns.Count + 1; i++)
                //    {
                //        MExcel.Cells[1, i] = gridTimetableList.Columns[i - 1].HeaderText;
                //    }
                //    for (int i = 0; i < gridTimetableList.Rows.Count; i++)
                //    {
                //        for (int j = 0; j < gridTimetableList.Columns.Count; j++)
                //        {
                //            MExcel.Cells[i + 2, j + 1] = gridTimetableList.Rows[i].Cells[j].Value.ToString();
                //        }
                //    }
                //    MExcel.Columns.AutoFit();
                //    MExcel.Rows.AutoFit();
                //    MExcel.Columns.Font.Size = 12;
                //    MExcel.Visible = true;
                //}
                //else
                //{
                //    MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else if (button1.Text == "Generate Time Table")
            {

                string subjectNo = dbHelper.getInfo("SELECT SubjectNo FROM subject_master WHERE AcademicYear='" + cmbYear.Text + "' AND Department='" + lbDepartment.Text + "' AND SemesterName='" + cmbSemesterName.Text + "'");
                labs = dbHelper.getInfo1("SELECT SubjectCode FROM class_subjects WHERE SubjectNo=" + subjectNo + " AND SubjectType='Lab' ORDER BY DURATION DESC");
                theory = dbHelper.getInfo1("SELECT SubjectCode FROM class_subjects WHERE SubjectNo=" + subjectNo + " AND SubjectType='Theory' ORDER BY DURATION DESC");
                int i = 0;
                while (i < gridTimetableList.Rows.Count)
                {
                    foreach (string str in labs)
                    {
                        //  MessageBox.Show(str);
                        if (i < gridTimetableList.Rows.Count)
                        {
                            string subjectName = dbHelper.getInfo("SELECT SubjectName FROM class_subjects WHERE SubjectNo=" + subjectNo + " AND SubjectCode='" + str + "'");
                            string subjectType = dbHelper.getInfo("SELECT SubjectType FROM class_subjects WHERE SubjectNo=" + subjectNo + " AND SubjectCode='" + str + "'");
                            string teacherName = dbHelper.getInfo("SELECT TeacherName FROM class_subjects WHERE SubjectNo=" + subjectNo + " AND SubjectCode='" + str + "'");
                            string result = subjectName;
                            if (subjectType == "Lab") result += "- Practical";
                            else if (subjectType == "Theory") result += "- Th";
                            result += "(" + teacherName + ")";
                            if (gridTimetableList.Rows[i].Cells[0].Value.ToString() != holiday)
                                gridTimetableList.Rows[i].Cells[7].Value = result;
                            i++;
                        }
                    }
                }
                i = 0;
                while (i < gridTimetableList.Rows.Count)
                {
                    int j = 1;
                    foreach (string str in theory)
                    {
                        string subjectName = dbHelper.getInfo("SELECT SubjectName FROM class_subjects WHERE SubjectNo=" + subjectNo + " AND SubjectCode='" + str + "'");
                        string subjectType = dbHelper.getInfo("SELECT SubjectType FROM class_subjects WHERE SubjectNo=" + subjectNo + " AND SubjectCode='" + str + "'");
                        string teacherName = dbHelper.getInfo("SELECT TeacherName FROM class_subjects WHERE SubjectNo=" + subjectNo + " AND SubjectCode='" + str + "'");
                        string result = subjectName;
                        if (subjectType == "Lab") result += "- Practical";
                        else if (subjectType == "Theory") result += "- Th";
                        result += "(" + teacherName + ")";
                        if (j < gridTimetableList.ColumnCount)
                        {
                            if (j != 4 && gridTimetableList.Rows[i].Cells[0].Value.ToString() != holiday)
                                gridTimetableList.Rows[i].Cells[j].Value = result;
                            j++;
                        }
                    }
                    i++;
                    RotateArrayListByOne(theory);
                }
                button1.Text = "Save And Download Timetable";

            }

        }
        void RotateArrayListByOne(ArrayList arrayList)
        {
            if (arrayList == null || arrayList.Count == 0)
            {
                return; // No rotation needed for empty or null ArrayList
            }

            // Store the first element
            var firstElement = arrayList[0];

            // Shift all elements to the left by 1
            for (int i = 0; i < arrayList.Count - 1; i++)
            {
                arrayList[i] = arrayList[i + 1];
            }

            // Place the first element at the end
            arrayList[arrayList.Count - 1] = firstElement;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int margin = 50;
            int yPosition = margin;

            // Draw the title centered at the top
            using (Font titleFont = new Font("Arial", 18, FontStyle.Bold))
            {
                SizeF titleSize = e.Graphics.MeasureString("TimeTable", titleFont);
                float titleXPosition = (e.PageBounds.Width / 2) - (titleSize.Width / 2);
                e.Graphics.DrawString("TimeTable", titleFont, Brushes.Black, titleXPosition, yPosition);
                yPosition += (int)titleSize.Height + 20; // Add some space below the title
            }

            // Draw the column headers
            int xPosition = margin;
            foreach (DataGridViewColumn column in gridTimetableList.Columns)
            {
                Rectangle headerRect = new Rectangle(xPosition, yPosition, column.Width, gridTimetableList.ColumnHeadersHeight);
                e.Graphics.FillRectangle(new SolidBrush(column.HeaderCell.Style.BackColor), headerRect);
                e.Graphics.DrawRectangle(Pens.Black, headerRect);
                e.Graphics.DrawString(column.HeaderText, column.HeaderCell.Style.Font, Brushes.Black, headerRect, new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
                xPosition += column.Width;
            }
            yPosition += gridTimetableList.ColumnHeadersHeight;

            // Draw the rows
            foreach (DataGridViewRow row in gridTimetableList.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row

                xPosition = margin;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Rectangle cellRect = new Rectangle(xPosition, yPosition, cell.OwningColumn.Width, cell.OwningRow.Height);
                    e.Graphics.FillRectangle(new SolidBrush(cell.Style.BackColor), cellRect);
                    e.Graphics.DrawRectangle(Pens.Black, cellRect);
                    e.Graphics.DrawString(cell.FormattedValue.ToString(), cell.Style.Font, Brushes.Black, cellRect, new StringFormat
                    {
                        Alignment = StringAlignment.Near,
                        LineAlignment = StringAlignment.Center
                    });
                    xPosition += cell.OwningColumn.Width;
                }
                yPosition += row.Height;
            }

            // Indicate that no further pages are to be printed
            e.HasMorePages = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
