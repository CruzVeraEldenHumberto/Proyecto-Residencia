using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Therapheye
{
    public partial class ControlPelli : UserControl
    {
        public int IDUser; //variable para guardar el id del usuario actual
        public string DTNow; //variable datetime para obtener fecha actual
        // variables para determinar la cantidad de respuestas correctas e incorrectas
        public int ContCorrecta = 0;
        public int ContIncorrecto = 0;
        public string Resultado; //resultado del test realizado
        public string Nota; //nota acerca del resultado del test

        Database databaseobject = new Database(); //creación del objeto de la base de datos

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
            if (textBox2.Text.ToUpper().Trim() == "VRSKDR")
            {
                textBox2.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox2.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox3.Text.ToUpper().Trim() == "NHCSOK")
            {
                textBox3.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox3.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox4.Text.ToUpper().Trim() == "SCNOZV")
            {
                textBox4.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox4.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox5.Text.ToUpper().Trim() == "CNHZOK")
            {
                textBox5.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox5.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox6.Text.ToUpper().Trim() == "NODVHR")
            {
                textBox6.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox6.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox7.Text.ToUpper().Trim() == "CDNZSV")
            {
                textBox7.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox7.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox8.Text.ToUpper().Trim() == "KCHODK")
            {
                textBox8.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox8.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox9.Text.ToUpper().Trim() == "RSZHVR")
            {
                textBox9.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox9.BackColor = Color.Red;
                Incorrect();
            }
            Resultado = ContCorrecta + "/8";
            if (ContCorrecta<2)
            {
                MessageBox.Show("Existe la posibilidad de que tenga una grave perdida de contraste en su vista. " + Resultado, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nota = "Grave deficiencia";
            }
            if (ContCorrecta > 1 && ContCorrecta <4)
            {
                MessageBox.Show("Existe la posibilidad de que tenga una moderada perdida de contraste en su vista. " + Resultado, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nota = "Moderada deficiencia";
            }
            if (ContCorrecta > 3 && ContCorrecta < 6)
            {
                MessageBox.Show("Existe la posibilidad de que tenga una ligera perdida de contraste en su vista. " + Resultado, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nota = "Ligera deficiencia";
            }
            if (ContCorrecta >5)
            {
                MessageBox.Show("Ha concluido la cartilla de constraste de Pelli-Robson satisfactoriamente, su vista está en buenas condiciones. " + Resultado, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nota = "Vista en buenas condiciones";
            }

            InsertRespuestas(); //llamada de metodo para poder insertar los datos a la base de datos
        }

        public void InsertRespuestas() //metodo para insertar datos acerca del ejercicio
        {
            IDUser = DBValue.valID; //Obtiene el ID del usuario actual

            //cadena la cual es un comando de sql para insertar datos dentro de la tabla Ejercicio_Contraste_Sensibilidad
            string query = "INSERT INTO Ejercicio_Contraste_Sensibilidad ('Id_Usuario', 'Fecha_Hora', 'Porcentaje_Aciertos', 'Nota') VALUES (@IDU, @Timestamp, @Re, @Nt)";
            //se crea un commando SQL en base a la cadena anterior
            SQLiteCommand mycommand = new SQLiteCommand(query, databaseobject.myConnection);

            databaseobject.OpenConnection(); //se abre la conexión de la base de datos

            DTNow = databaseobject.GetDateTime(); //se obtiene la fecha actual

            //se añaden los parametros con los valores establecidos
            mycommand.Parameters.AddWithValue("@IDU", IDUser);
            mycommand.Parameters.AddWithValue("@Timestamp", DTNow);
            mycommand.Parameters.AddWithValue("@Re", Resultado);
            mycommand.Parameters.AddWithValue("@Nt", Nota);

            mycommand.ExecuteNonQuery(); //ejecuta el comando SQL
            //restablece los valores 
            ContCorrecta = 0;
            ContIncorrecto = 0;

            databaseobject.CloseConnection(); //cierra la conexión de la base de datos
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
        public void Correct()
        {
            ContCorrecta = ContCorrecta + 1;
        }

        public void Incorrect()
        {
            ContIncorrecto = ContIncorrecto + 1;
        }
    }
}
