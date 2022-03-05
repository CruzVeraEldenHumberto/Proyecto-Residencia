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
    public partial class FormFocus : Form
    {
        public FormFocus()
        {
            InitializeComponent();
        }

        private void FormFocus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlAcercarAlejar1.Visible = true;
            controlAcercarAlejar1.BringToFront();

            controlEnfoqueDistancia1.Visible = false;
            controlMasajeFrontal1.Visible = false;
            controlMasajeSuperior1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            controlEnfoqueDistancia1.Visible = true;
            controlEnfoqueDistancia1.BringToFront();

            controlAcercarAlejar1.Visible = false;
            controlMasajeFrontal1.Visible = false;
            controlMasajeSuperior1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            controlMasajeFrontal1.Visible = true;
            controlMasajeFrontal1.BringToFront();

            controlAcercarAlejar1.Visible = false;
            controlEnfoqueDistancia1.Visible = false;
            controlMasajeSuperior1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            controlMasajeSuperior1.Visible = true;
            controlMasajeSuperior1.BringToFront();

            controlAcercarAlejar1.Visible = false;
            controlEnfoqueDistancia1.Visible = false;
            controlMasajeFrontal1.Visible = false;
        }
    }
}
