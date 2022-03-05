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
    public partial class ControlInfinitocs : UserControl
    {
        public ControlInfinitocs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMov.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInfinito fi = new FormInfinito();
            fi.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
