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
    public partial class ControlAlternar : UserControl
    {
        public ControlAlternar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMov.ActiveForm.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void ControlAlternar_Load(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\cuchara.gif");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
