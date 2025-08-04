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
    public partial class frmDashboardAdmin : Form
    {
        public frmDashboardAdmin()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //adminPanel1.Visible = false;

            if (adminPanel1.Visible)
            {
                adminPanel1.Visible = false;
            }
            else
            {
                adminPanel1.Visible = true;
            }

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboardAdmin_Load(object sender, EventArgs e)
        {
            uC_AddExam1.Visible = false;
            uC_homeadmin2.Visible = false;
            uC_info1.Visible = false;
            uC_question1.Visible = false;
        }

        private void btnhome1_Click(object sender, EventArgs e)
        {
            uC_homeadmin1.Visible = true;
        }

        private void btnhome1_Click_1(object sender, EventArgs e)
        {
            uC_homeadmin2.Visible = true;
            uC_homeadmin2.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void adminPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnQuize_Click(object sender, EventArgs e)
        {
            uC_AddExam1.Visible = true;
            uC_AddExam1.BringToFront();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            uC_info1.Visible = true;
            uC_info1.BringToFront();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            uC_question1.Visible = true;
            uC_question1.BringToFront();

        }

        private void uC_question1_Load(object sender, EventArgs e)
        {

        }
    }
}
