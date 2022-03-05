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
    public partial class ControlInicio : UserControl
    {
        public ControlInicio()
        {
            InitializeComponent();
        }

        private void ControlInicio_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Therapeye: Evaluación y recomendaciones para la fatiga visual y vision escotópica", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se trata de una aplicación que te ayudará a conocer si presentas indicios sobre alguna condicion que pueda afectar a tu salud ocular. Tras la realización de los diferentes ejercicios que encontrarás en los siguientes apartados podrás determinar si consideras necesario recurrir a una asistencia médica más especializada, dado que este programa no pretende suplir el papel de un profesional en el área médica, se recomienda el uso de las herramientas presentes como una guía base y no ser  percibido como plan de acción definitivo para la mejora de su salud ocular.", "¿Qué es?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para brindar resultados más precisos y objetivos se recomienda llevar a cabo los ejercicios en rangos de hora específicos, los cuales se detallan en el panel adyacente. Cada columna parte de diferentes tipos de horas acorde al ciclo horario que más se acomode al usuario según sea su rutina.", "Horario de uso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.- Inicie realizando el cuestionario inicial en el botón 'Test Inicial'. 2.- Realiza los ejercicios presentados en la sección 'Ejercicios'. 3.- Finaliza realizando un breve cuestionario en el cual podrás describir tu experiencia tras el uso de Therapeye" , "¿Cómo se usa?", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Investigación y Desarrollo: Cortes Chavarín Merari Livannette 17210548 y González Sepúlveda Genaro Eugenio 16212017 ", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
