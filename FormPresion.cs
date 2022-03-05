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
    public partial class FormPresion : Form
    {
        public FormPresion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlPresionSimple1.Visible = true;
            controlPresionSimple1.BringToFront();
            

            controlPresionMano1.Visible = false;
            controlPresionCuenca1.Visible = false;
            controlPresionCuenca1.Visible = false;
            controlMasajeCuenca1.Visible = false;
        }

        private void controlPresionSimple1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            controlPresionMano1.Visible = true;
            controlPresionMano1.BringToFront();

            controlPresionSimple1.Visible = false;
            controlPresionCuenca1.Visible = false;
           
            controlMasajeCuenca1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            controlPresionCuenca1.Visible = true;
            controlPresionCuenca1.BringToFront();

            controlPresionSimple1.Visible = false;
            //controlPresionMano1.Visible = false;
            
            controlMasajeCuenca1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            controlMasajeGlobo1.Visible = true;
            controlMasajeGlobo1.BringToFront();

            controlPresionSimple1.Visible = false;
            //controlPresionMano1.Visible = false;
            controlPresionCuenca1.Visible = false;
            controlMasajeCuenca1.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            controlMasajeCuenca1.Visible = true;
            controlMasajeCuenca1.BringToFront();

            controlPresionSimple1.Visible = false;
            //controlPresionMano1.Visible = false;
            controlPresionCuenca1.Visible = false;
            controlMasajeGlobo1.Visible = false;
        }
    }
}
