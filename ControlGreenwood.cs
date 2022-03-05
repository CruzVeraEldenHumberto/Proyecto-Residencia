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
    public partial class ControlGreenwood : UserControl
    {
        public ControlGreenwood()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVisNoc.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTestGreenwood ftg = new FormTestGreenwood();
            ftg.ShowDialog();
        }
    }
}
