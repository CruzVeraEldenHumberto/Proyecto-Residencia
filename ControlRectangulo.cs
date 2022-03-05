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
    public partial class ControlRectangulo : UserControl
    {
        public ControlRectangulo()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRectagulo fr = new FormRectagulo();
            fr.ShowDialog();
        }

        private void ControlRectangulo_Load(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\rectangulo.gif");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMov.ActiveForm.Close();
        }
    }
}
