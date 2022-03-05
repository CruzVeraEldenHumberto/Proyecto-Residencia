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
    public partial class ControlEjercicios : UserControl
    {
        public ControlEjercicios()
        {
            InitializeComponent();
        }

        private void ControlEjercicios_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormVisNoc vn = new FormVisNoc();
            vn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMov fm = new FormMov();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFocus ff = new FormFocus();
            ff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPresion presion = new FormPresion();
            presion.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormHabitos habitos = new FormHabitos();
            habitos.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormSuplementos fs = new FormSuplementos();
            fs.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            FormSuplementos fs = new FormSuplementos();
            fs.ShowDialog();
        }
    }
}
