﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;
namespace Therapheye
{
    public partial class ControlPresionMano : UserControl
    {

        Stopwatch reloj = new Stopwatch();
        public ControlPresionMano()
        {
            InitializeComponent();
        }

        

        private void ControlPresionMano_Load(object sender, EventArgs e)
        {
            txtSeg.Text = "00";
            txtMil.Text = "000";

            //if (this.ActiveControl.IsDisposed) { reloj.Reset(); }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reloj.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)reloj.ElapsedMilliseconds);

            //txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            txtMil.Text = ts.Milliseconds.ToString();


            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\ring2.wav");
            System.Media.SoundPlayer toca = new System.Media.SoundPlayer("ring.wav");
            if (ts.Seconds == 9 ) { player.Play(); }
            if (ts.Seconds == 20 ) { player.Play(); reloj.Reset(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reloj.Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reloj.Reset();
            FormPresion.ActiveForm.Close();
            FormPresion.ActiveForm.Dispose();
            this.Dispose();
        }

        private void ControlPresionMano_Leave(object sender, EventArgs e)
        {
            reloj.Reset();
            
        }
    }
}
