using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Therapheye
{
    public partial class FormMov : Form
    {
        public FormMov()
        {
            InitializeComponent();
        }

        private void FormMov_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlAlternar1.BringToFront();
            controlAlternar1.Visible = true;

            controlMultiVista1.Visible = false;
            controlCirculo1.Visible = false;
            controlRectangulo1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            controlMultiVista1.BringToFront();
            controlMultiVista1.Visible = true;

            controlAlternar1.Visible = false;
            controlCirculo1.Visible = false;
            controlRectangulo1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMov.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            controlCirculo1.BringToFront();
            controlCirculo1.Visible = true;

            controlMultiVista1.Visible = false;
            controlAlternar1.Visible = false;
            controlRectangulo1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            controlInfinitocs1.BringToFront();
            controlInfinitocs1.Visible = true;

            controlMultiVista1.Visible = false;
            controlAlternar1.Visible = false;
            controlCirculo1.Visible = false;
            controlRectangulo1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            controlRectangulo1.BringToFront();
            controlRectangulo1.Visible = true;

            controlMultiVista1.Visible = false;
            controlAlternar1.Visible = false;
            controlCirculo1.Visible = false;
            controlInfinitocs1.Visible = false;

        }
    }
}
