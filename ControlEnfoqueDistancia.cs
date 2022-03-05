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
    public partial class ControlEnfoqueDistancia : UserControl
    {
        public ControlEnfoqueDistancia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEnfoqueDistancia fed = new FormEnfoqueDistancia();
            fed.ShowDialog();
        }
    }
}
