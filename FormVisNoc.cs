using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SQLite;

namespace Therapheye
{
    public partial class FormVisNoc : Form
    {
        public FormVisNoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlPelli1.BringToFront();
            controlPelli1.Visible = true;
            this.ControlBox = false;

            controlIshihara1.Visible = false;
            controlAmsler1.Visible = false;
            controlGreenwood1.Visible = false;
            controlCirculoHorario1.Visible = false;
        }

        private void controlPelli1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            controlIshihara1.BringToFront();
            controlIshihara1.Visible = true;
            this.ControlBox = false;

            controlPelli1.Visible = false;
            controlGreenwood1.Visible = false;
            controlAmsler1.Visible = false;
            controlCirculoHorario1.Visible = false;
        }

        private void controlIshihara1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            controlAmsler1.BringToFront();
            controlAmsler1.Visible = true;

            controlPelli1.Visible = false;
            controlIshihara1.Visible = false;
            controlGreenwood1.Visible = false;
            controlCirculoHorario1.Visible = false;
        }

        private void controlAmsler1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            controlGreenwood1.BringToFront();
            controlGreenwood1.Visible = true;

            controlIshihara1.Visible = false;
            controlAmsler1.Visible = false;
            controlPelli1.Visible = false;
            controlCirculoHorario1.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            controlCirculoHorario1.BringToFront();
            controlCirculoHorario1.Visible = true;

            controlIshihara1.Visible = false;
            controlAmsler1.Visible = false;
            controlPelli1.Visible = false;
            controlGreenwood1.Visible = false;

        }

        private void controlCirculoHorario1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
