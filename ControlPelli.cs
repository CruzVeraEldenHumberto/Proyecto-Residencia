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
        // variables para las respuestas del usuario
        public string Resp1;
        public string Resp2;
        public string Resp3;
        public string Resp4;
        public string Resp5;
        public string Resp6;
        public string Resp7;
        public string Resp8;
        public string DTNow;
        public int IDUser; //id del usuario
        public string Datetime; //variable datetime para obtener fecha actual
        Database databaseobject = new Database();


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
                Resp1 = Correct();
            }
            else
            {
                textBox2.BackColor = Color.Red;
                Resp1 = Incorrect();
            }

            if (textBox3.Text.ToUpper().Trim() == "NHCSOK")
            {
                textBox3.BackColor = Color.Green;
                Resp2 = Correct();
            }
            else
            {
                textBox3.BackColor = Color.Red;
                Resp2 = Incorrect();
            }

            if (textBox4.Text.ToUpper().Trim() == "SCNOZV")
            {
                textBox4.BackColor = Color.Green;
                Resp3 = Correct();
            }
            else
            {
                textBox4.BackColor = Color.Red;
                Resp3 = Incorrect();
            }

            if (textBox5.Text.ToUpper().Trim() == "CNHZOK")
            {
                textBox5.BackColor = Color.Green;
                Resp4 = Correct();
            }
            else
            {
                textBox5.BackColor = Color.Red;
                Resp4 = Incorrect();
            }

            if (textBox6.Text.ToUpper().Trim() == "NODVHR")
            {
                textBox6.BackColor = Color.Green;
                Resp5 = Correct();
            }
            else
            {
                textBox6.BackColor = Color.Red;
                Resp5 = Incorrect();
            }

            if (textBox7.Text.ToUpper().Trim() == "CDNZSV")
            {
                textBox7.BackColor = Color.Green;
                Resp6 = Correct();
            }
            else
            {
                textBox7.BackColor = Color.Red;
                Resp6 = Incorrect();
            }

            if (textBox8.Text.ToUpper().Trim() == "KCHODK")
            {
                textBox8.BackColor = Color.Green;
                Resp7 = Correct();
            }
            else
            {
                textBox8.BackColor = Color.Red;
                Resp7 = Incorrect();
            }

            if (textBox9.Text.ToUpper().Trim() == "RSZHVR")
            {
                textBox9.BackColor = Color.Green;
                Resp8 = Correct();
            }
            else
            {
                textBox9.BackColor = Color.Red;
                Resp8 = Incorrect();
            }

            if (textBox2.BackColor == Color.Green &&
                textBox3.BackColor == Color.Green &&
                textBox4.BackColor == Color.Green &&
                textBox5.BackColor == Color.Green &&
                textBox6.BackColor == Color.Green &&
                textBox7.BackColor == Color.Green &&
                textBox8.BackColor == Color.Green &&
                textBox9.BackColor == Color.Green)
            {
                MessageBox.Show("Ha concluido la cartilla de constraste de Pelli-Robson satisfactoriamente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            InsertRespuestas();
        }


        public void InsertRespuestas()
        {
            DBValue idval = new DBValue();
            IDUser = idval.IDValue(1);

            string query = "INSERT INTO Ejercicio_Contraste_Sensibilidad ('Id_Usuario', 'Fecha_Hora', 'Primer_Respuesta', 'Segunda_Respuesta', 'Tercer_Respuesta', 'Cuarta_Respuesta', 'Quinta_Respuesta', 'Sexta_Respuesta', 'Septima_Respuesta', 'Octava_Respuesta') VALUES (@IDU, @Timestamp, @R1, @R2, @R3, @R4, @R5, @R6, @R7, @R8)";
            SQLiteCommand mycommand = new SQLiteCommand(query, databaseobject.myConnection);

            databaseobject.OpenConnection();

            DTNow = databaseobject.GetDateTime();

            mycommand.Parameters.AddWithValue("@IDU", IDUser);
            mycommand.Parameters.AddWithValue("@Timestamp", DTNow);
            mycommand.Parameters.AddWithValue("@R1", Resp1);
            mycommand.Parameters.AddWithValue("@R2", Resp2);
            mycommand.Parameters.AddWithValue("@R3", Resp3);
            mycommand.Parameters.AddWithValue("@R4", Resp4);
            mycommand.Parameters.AddWithValue("@R5", Resp5);
            mycommand.Parameters.AddWithValue("@R6", Resp6);
            mycommand.Parameters.AddWithValue("@R7", Resp7);
            mycommand.Parameters.AddWithValue("@R8", Resp8);

            mycommand.ExecuteNonQuery();
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
        public string Correct()
        {
            return "Correcta";
        }

        public string Incorrect()
        {
            return "Incorrecta";
        }
    }
}
