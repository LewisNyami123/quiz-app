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
    public partial class student1 : Form
    {
        public student1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void student1_Load(object sender, EventArgs e)
        {
            uC_Home1.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            uC_Home1.Visible = true;
        }
    }
}
