using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Xamarin.Forms;

namespace Therapheye
{


    public partial class FormTestGreenwood : Form
    {

       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            /* for (int i=0; i<24; i++)
               {
                   if (imagenes[i].ToString() == imagenes[i] && keyData == Keys.Right) { 

                   };
               }*/
            for (int i = 0; i < 24; i++) {
                pictos[i].Visible = true;
                if (imagenes[i].ToString() == keyData.ToString())
                {
                    pictos[i].Visible = true;
                }
                else {
                    pictos[i].Visible = false;
                }
               // MessageBox.Show(imagenes[i].ToString());
            }
           /* for (int i = 0; i < 24; i++)
                if (imagenes[i].ToString() == )
            {

            };

           
            if (imagenes[0].ToString() == "der" && keyData == Keys.Right) { pictureBox2.Dispose(); }
                if (imagenes[1].ToString() == "arr" && keyData == Keys.Up) { pictureBox3.Hide(); }
                if (imagenes[2].ToString() == "izq" && keyData == Keys.Left) { pictureBox4.Hide(); }
                if (imagenes[3].ToString() == "arr" && keyData == Keys.Up) { pictureBox10.Hide(); }*/
            
           
            //Gestion de flechas
            //Capturar flecha arriba
            /*
             * if (imagenes[0].ToString() == "der" && keyData == Keys.Right)
            {
                pictureBox2.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox2.BackgroundImage = Therapheye.Properties.Resources._33; }
            
            if (imagenes[1].ToString() == "arr" && keyData == Keys.Up)
            {
                pictureBox3.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox3.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[2].ToString() == "izq" && keyData == Keys.Left)
            {
                pictureBox4.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox4.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[3].ToString() == "arr" && keyData == Keys.Up)
            {
                pictureBox10.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox10.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[4].ToString() == "der" && keyData == Keys.Right)
            {
                pictureBox9.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox9.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[5].ToString() == "arr" && keyData == Keys.Up)
            {
                pictureBox8.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox8.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[6].ToString() == "der" && keyData == Keys.Right)
            {
                pictureBox13.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox13.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[7].ToString() == "izq" && keyData == Keys.Left)
            {
                pictureBox12.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox12.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[8].ToString() == "arr" && keyData == Keys.Up)
            {
                pictureBox11.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox11.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[9].ToString() == "aba" && keyData == Keys.Down)
            {
                pictureBox16.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox16.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[10].ToString() == "izq" && keyData == Keys.Left)
            {
                pictureBox15.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox15.BackgroundImage = Therapheye.Properties.Resources._33; }

            if (imagenes[11].ToString() == "arr" && keyData == Keys.Up)
            {
                pictureBox14.BackgroundImage = Therapheye.Properties.Resources._32;
            }
            else { pictureBox14.BackgroundImage = Therapheye.Properties.Resources._33; }
            */

            //Segmento derecho


            if (keyData == Keys.Up)
            {
                //MessageBox.Show("You pressed Up arrow key");
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                //MessageBox.Show("You pressed Down arrow key");
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                //MessageBox.Show("You pressed Left arrow key");
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                //MessageBox.Show("You pressed Right arrow key");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

      

        string[] imagenes = new string[24] { 
            "Right", "Up", "Left",
            "Up", "Right", "Right",
            "Right", "Left", "Up",
            "Down", "Left", "Up",
            "Right", "Left", "Up",
            "Right", "Up", "Down",
            "Up", "Down", "Left",
            "Right", "Up", "Down"
        };



        PictureBox[] pictos = new PictureBox[24]; 
        
        
    public FormTestGreenwood()
        {
            InitializeComponent();
            pictos[0] = pictureBox2;
            pictos[1] = pictureBox3;
            pictos[2] = pictureBox4;
            pictos[3] = pictureBox10;
            pictos[4] = pictureBox9;
            pictos[5] = pictureBox8;
            pictos[6] = pictureBox13;
            pictos[7] = pictureBox12;
            pictos[8] = pictureBox11;
            pictos[9] = pictureBox16;
            pictos[10] = pictureBox15;
            pictos[11] = pictureBox14;
            pictos[12] = pictureBox7;
            pictos[13] = pictureBox6;
            pictos[14] = pictureBox5;
            pictos[15] = pictureBox20;
            pictos[16] = pictureBox19;
            pictos[17] = pictureBox18;
            pictos[18] = pictureBox23;
            pictos[19] = pictureBox22;
            pictos[20] = pictureBox21;
            pictos[21] = pictureBox26;
            pictos[22] = pictureBox25;
            pictos[23] = pictureBox24;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTestGreenwood.ActiveForm.Close();
        }

        private void FormTestGreenwood_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_BackgroundImageChanged(object sender, EventArgs e)
        {
            
            pictureBox2.Dispose();
        }

        private void pictureBox17_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
