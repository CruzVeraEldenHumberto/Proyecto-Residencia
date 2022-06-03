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
    public partial class FormMensaje : Form
    {
        public FormMensaje()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
        }

        public string valorMensaje
        {
            get { return textBox2.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
