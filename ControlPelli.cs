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
    public partial class ControlPelli : UserControl
    {
        public ControlPelli()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ControlPelli_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToUpper().Trim() == "VRSKDR") { textBox2.BackColor = Color.Green; } else { textBox2.BackColor = Color.Red; }
            if (textBox3.Text.ToUpper().Trim() == "NHCSOK") { textBox3.BackColor = Color.Green; } else { textBox3.BackColor = Color.Red; }
            if (textBox4.Text.ToUpper().Trim() == "SCNOZV") { textBox4.BackColor = Color.Green; } else { textBox4.BackColor = Color.Red; }
            if (textBox5.Text.ToUpper().Trim() == "CNHZOK") { textBox5.BackColor = Color.Green; } else { textBox5.BackColor = Color.Red; }
            if (textBox6.Text.ToUpper().Trim() == "NODVHR") { textBox6.BackColor = Color.Green; } else { textBox6.BackColor = Color.Red; }
            if (textBox7.Text.ToUpper().Trim() == "CDNZSV") { textBox7.BackColor = Color.Green; } else { textBox7.BackColor = Color.Red; }
            if (textBox8.Text.ToUpper().Trim() == "KCHODK") { textBox8.BackColor = Color.Green; } else { textBox8.BackColor = Color.Red; }
            if (textBox9.Text.ToUpper().Trim() == "RSZHVR") { textBox9.BackColor = Color.Green; } else { textBox9.BackColor = Color.Red; }


        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVisNoc.ActiveForm.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }
    }
}
