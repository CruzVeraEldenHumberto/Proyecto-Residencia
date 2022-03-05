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
                concepto = "1.- ¿Acostumbra usar pantallas durante periodos de tiempo mayores a 6 horas?",
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
                concepto = "2.- ¿Tiene problemas para enfocar objetos a corta distancia?",
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
                concepto = "3.- ¿Suele tener la vista cansada al finalizar el día?",
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
                concepto = "4.- ¿Le duele la cabeza al intentar enfocar la vista?",
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
                concepto = "5.- ¿Considera que olvida parpadear frecuentemente?",
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
                concepto = "6.- ¿Usa pantallas en entornos con iluminación mal regulada (Ej. Bastante luz entrante por la ventana)?",
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
                concepto = "7.- ¿Tiene dificultad para ver en la oscuridad?",
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
                concepto = "8.- ¿Tiene deficiencias alimenticias?",
                resp1 = "No",
                valor1 = val1,
                resp2 = "No estoy segur@",
                valor2 = val2,
                resp3 = "Probablemente",
                valor3 = val3,
                resp4 = "Si",
                valor4 = val4

            });

            encuesta.Add(new cuestion
            {
                concepto = "9.- ¿En su familia existen casos o antecedentes de condiciones oculares hereditarias?",
                resp1 = "No",
                valor1 = val1,
                resp2 = "Muy pocos",
                valor2 = val2,
                resp3 = "Algunos",
                valor3 = val3,
                resp4 = "Bastantes",
                valor4 = val4

            });

            encuesta.Add(new cuestion
            {
                concepto = "10.- ¿Olvida activar algún filtro contra luz azul en las pantallas que usa?",
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
            richTextBox1.Visible = false;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            RealizaPregunta();
            button1.Visible = false;
            btnSiguiente.Visible = true;
            label1.Visible = false;

        }
        private void RealizaPregunta() 
        {
            cuestion pregunta = new cuestion();
            pregunta = encuesta[numPreg];
            richTextBox2.Text = pregunta.concepto;
            richTextBox2.Text = pregunta.concepto;
            richTextBox2.Visible = true;

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
            if ((numPreg < encuesta.Count() - 1))
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
            richTextBox2.Visible = false;
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
            
            if (sumResp <= lim1)
            {
                richTextBox1.Text = "No has proporcionado ninguna respuesta, por favor repite el cuestionario.";
            }

            if (sumResp <= lim2)
            {
                richTextBox1.Text = "De acuerdo a las respuestas que ha proporcionado, sus hábitos y salud ocular son adecuados, por lo que probablemente no tenga complicaciones visuales. Sin embargo las pruebas están a su disposición si así lo desea. Igualmente puede acceder al resto de los módulos para conocer diferentes hábitos que le permitirán ejercitar y mantener sus ojos en buen estado.";

               
            }
            if (sumResp > lim2 && sumResp <= lim4) 
            {
                richTextBox1.Text = "De acuerdo a las respuestas que ha proporcionado, se concluye que su vista se encuentra en buen estado, sin embargo pueden existir algunos factores que puede mejorar para evitar futuros problemas en su salud ocular. Se le invita a ingresar a los módulos de nuevos hábitos y de suplementos para conocer recomendaciones que le pueden ayudar a mantener una vista sana";
            }
            if (sumResp > lim4 && sumResp <= lim6) 
            {
                richTextBox1.Text = "De acuerdo a las respuestas que ha proporcionado, su salud ocular puede estar en riesgo de padecer algunos problemas de salud si no son atendidos en el futuro, por lo que se le recomienda realizar los diferentes ejercicios que podrá encontrar en cada módulo dentro de la sección de ejercicios.";
            }
            if (sumResp > lim6)
            {
                richTextBox1.Text = "De acuerdo a las respuestas que ha proporcionado se le recomienda realizar la terapia completa, siguiendo las instrucciones de cada uno de los módulos y leyendo las indicaciones para adoptar hábitos nuevos que podrán facilitar el mejoramiento y recuperación de su salud ocular. Además de la realización de las pruebas se recomienda acudir a un centro de salud para recibir asistencia más especializada y efectiva. Mucho éxito en su progreso!";
            }
            richTextBox1.Visible = true;
            double avance = (double)sumResp / (double)lim7 * 100.0;

            button1.Visible = true;
            label1.Visible = true;

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
           
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
