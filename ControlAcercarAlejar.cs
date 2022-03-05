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
    public partial class ControlAcercarAlejar : UserControl
    {
        public ControlAcercarAlejar()
        {
            InitializeComponent();
        }

        private void ControlAcercarAlejar_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\acercarAlejar.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
