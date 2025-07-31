using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_app
{
    public partial class frmDashboardTeacher : Form
    {
        private const bool V = true;

        public frmDashboardTeacher()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            uC_CreateExam1.Visible = true;
            uC_CreateExam1.BringToFront();
        }

        private void frmDashboardTeacher_Load(object sender, EventArgs e)
        {
            uC_CreateExam1.Visible = false;
            uC_ManageQuestion1.Visible = false;
            uC_StudentPerformancecs1.Visible = false;
            uC_Calender1.Visible = false;
            uC_Profile1.Visible = false;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            uC_ManageQuestion1.Visible = true;
            uC_ManageQuestion1.BringToFront();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            uC_StudentPerformancecs1.Visible = true;
            uC_StudentPerformancecs1.BringToFront();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            uC_Calender1.Visible = true;
            uC_Calender1.BringToFront();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }
    }
}
