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
    public partial class ControlTestInicial : UserControl
    {
        private List<cuestion> encuesta = new List<cuestion>();
        private int val1 = 0;
        private int val2 = 5;
        private int val3 = 10;
        private int val4 = 15;
        private int numPreg = 0;
        private int sumResp = 0;
        public ControlTestInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ControlTestInicial_Load(object sender, EventArgs e)
        {
            llenaEncuesta();
        }

        private void llenaEncuesta()
        {
            cuestion pregunta = new cuestion();
            encuesta.Add(new cuestion
            {
                concepto = "1.- ¿Acostumbra hacer uso de pantallas durante periodos de tiempo mayores a 6 horas?",
                resp1 = "No",
                valor1 = val1,
                resp2 = "Rara vez",
                valor2 = val2,
                resp3 = "Comunmente",
                valor3 = val3,
                resp4 = "Si",
                valor4 = val4
                
            });

            encuesta.Add(new cuestion
            {
                concepto = "2.- ¿Presenta problemas para enfocar objetos a corta distancia?",
                resp1 = "No",
                valor1 = val1,
                resp2 = "Rara vez",
                valor2 = val2,
                resp3 = "Comunmente",
                valor3 = val3,
                resp4 = "Si",
                valor4 = val4

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton para iniciar la encuesta
            numPreg = 0;
            sumResp = 0;
            lblResultado.Visible = false;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            RealizaPregunta();
            button1.Visible = false;
            btnSiguiente.Visible = true;


        }
        private void RealizaPregunta() 
        {
            cuestion pregunta = new cuestion();
            pregunta = encuesta[numPreg];
            lblPregunta.Text = pregunta.concepto;
            lblPregunta.Visible = true;

            radioButton1.Text = pregunta.resp1;
            radioButton1.Checked = false;
            radioButton1.Visible = true;

            radioButton2.Text = pregunta.resp2;
            radioButton2.Checked = false;
            radioButton2.Visible = true;

            radioButton3.Text = pregunta.resp3;
            radioButton3.Checked = false;
            radioButton3.Visible = true;

            radioButton4.Text = pregunta.resp4;
            radioButton4.Checked = false;
            radioButton4.Visible = true;



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Pendiente cambiar comportamiento de los elementos visibles al iniciar el cuestionario en ControlTestInicial.cs
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cuestion pregunta = new cuestion();
            pregunta = encuesta[numPreg];
            if (radioButton1.Checked == true) { sumResp += pregunta.valor1; }
            if (radioButton2.Checked == true) { sumResp += pregunta.valor2; }
            if (radioButton3.Checked == true) { sumResp += pregunta.valor3; }
            if (radioButton4.Checked == true) { sumResp += pregunta.valor4; }
            if (numPreg < encuesta.Count() - 1)
            {
                numPreg++;
                RealizaPregunta();
            }
            else
            {
                PresentaResultado();
            }
        }
        private void PresentaResultado() {
            lblPregunta.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            btnSiguiente.Visible = false;
            numPreg++;
            int lim1 = numPreg * val1;
            int lim3 = numPreg * val2;
            int lim5 = numPreg * val3;
            int lim7 = numPreg * val4;
            int lim2 = (lim3 - lim1) / 2 + lim1;
            int lim4 = (lim5 - lim3) / 2 + lim3;
            int lim6 = (lim7 - lim5) / 2 + lim5;
            
            if (sumResp <= lim2)
            {
                lblResultado.Text = "Su vista esta en buen estado pero procure relajar la vista constantemente";
            }
            if (sumResp > lim2 && sumResp <= lim4) 
            {
                lblResultado.Text = "Intente practicar los ejercicios tal y tal";
            }
            if (sumResp > lim4 && sumResp <= lim6) 
            {
                lblResultado.Text = "Realice estos ejercicios";
            }
            if (sumResp > lim6)
            {
                lblResultado.Text = "Necesita mejorar su vista";
            }
            lblResultado.Visible = true;
            double avance = (double)sumResp / (double)lim7 * 100.0;

            button1.Visible = true;

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
           
        }
    }
}
