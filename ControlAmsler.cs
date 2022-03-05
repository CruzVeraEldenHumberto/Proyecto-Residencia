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
    public partial class ControlAmsler : UserControl
    {
        public ControlAmsler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVisNoc.ActiveForm.Close();
        }

        private void ControlAmsler_Load(object sender, EventArgs e)
        {

        }
    }
}
