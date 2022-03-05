using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Therapheye
{
    public partial class Inicio : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );

        public Inicio()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlInicio2.BringToFront();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlInicio2.BringToFront();
            controlEjercicios1.Visible = false;
            controlInicio2.Visible = true;
            button1.BackColor = Color.FromArgb(99, 117, 237);
            button1.ForeColor = Color.Black;

            

        }

        private void button2_Click(object sender, EventArgs e) 
        { 
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            controlTestInicial2.Visible = true;
            controlTestInicial2.BringToFront();
            controlEjercicios1.Visible = false;
            controlInicio2.Visible = false;
            button2.BackColor = Color.FromArgb(99, 117, 237);
            button2.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            button3.BackColor = Color.FromArgb(99, 117, 237);
            button3.ForeColor = Color.Black;
        }

        private void EjercicioMovimiento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            button4.BackColor = Color.FromArgb(99, 117, 237);
            button4.ForeColor = Color.Black;
            MessageBox.Show("Therapeye: Evaluación y recomendaciones para la fatiga visual y vision escotópica", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            controlEjercicios1.BringToFront();
            controlEjercicios1.Visible = true;
            controlInicio2.Visible = false;
            controlTestInicial2.Visible = false;
            controlTestFinal1.Visible = false;
            button5.BackColor = Color.FromArgb(99, 117, 237);
            button5.ForeColor = Color.Black;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            controlTestFinal1.BringToFront();
            controlTestInicial2.Visible = false;
            controlEjercicios1.Visible = false;
            controlInicio2.Visible = false;
            controlTestFinal1.Visible = true;
            button6.BackColor = Color.FromArgb(99, 117, 237);
            button6.ForeColor = Color.Black;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void controlEjercicios1_Load(object sender, EventArgs e)
        {

        }

        private void controlTestFinal1_Load(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
            String fecha = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            

            //textBox1.Text.Contains(fecha);
            //textBox1.AppendText(fecha);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
            //String hora = DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            //textBox2.AppendText(hora);
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            textBox2.Text = DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 56, 68);
            button1.ForeColor = Color.White;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(0, 56, 68);
            button2.ForeColor = Color.White;
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(0, 56, 68);
            button5.ForeColor = Color.White;
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(0, 56, 68);
            button6.ForeColor = Color.White;
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(0, 56, 68);
            button4.ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com/es-es/windows/configura-la-pantalla-para-la-noche-en-windows-18fe903a-e0a1-8326-4c68-fd23d7aaf136#Category=Windows_10");
        }
    }
   
}
