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
    public partial class ControlIshihara : UserControl
    {
        public string DTNow;
        public string Nota;
        public int IDUser; //id del usuario
        public string Datetime; //variable datetime para obtener fecha actual
        Database databaseobject = new Database();
        public int ContCorrecta=0;
        public int ContIncorrecto=0;
        //public double Porcentaje;
        public string Resultado;

        public ControlIshihara()
        {
            InitializeComponent();
        }

        private void ControlIshihara_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\11.png");
            pictureBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\12.png");
            pictureBox2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\13.png");
            pictureBox3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\14.png");
            pictureBox4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\15.png");
            pictureBox5.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox6.BringToFront();
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\16.png");
            pictureBox6.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\Ishihara_07.jpg");
            pictureBox1.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\Ishihara_08.jpg");
            pictureBox2.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\Ishihara_09.jpg");
            pictureBox3.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\Ishihara_10.jpg");
            pictureBox4.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\Ishihara_11.jpg");
            pictureBox5.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox6.BringToFront();
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\Ishihara_12.jpg");
            pictureBox6.Visible = true;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            FormVisNoc.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "12")
            {
                textBox2.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox2.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox3.Text == "74")
            {
                textBox3.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox3.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox4.Text == "6")
            {
                textBox4.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox4.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox5.Text == "16")
            {
                textBox5.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox5.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox6.Text == "2")
            {
                textBox6.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox6.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox7.Text == "29")
            {
                textBox7.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox7.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox13.Text == "45")
            {
                textBox13.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox13.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox12.Text == "5")
            {
                textBox12.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox12.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox11.Text == "97")
            {
                textBox11.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox11.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox10.Text == "8")
            {
                textBox10.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox10.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox9.Text == "42")
            {
                textBox9.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox9.BackColor = Color.Red;
                Incorrect();
            }

            if (textBox8.Text == "3")
            {
                textBox8.BackColor = Color.Green;
                Correct();
            }
            else
            {
                textBox8.BackColor = Color.Red;
                Incorrect();
            }

            Resultado = ContCorrecta + "/12";
            if(ContCorrecta >= 10)
            {
                MessageBox.Show("Ha concluido el test de Ishihara satisfactoriamente. " + Resultado,"Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nota = "Visión de color normal";
            }
            else
            {
                MessageBox.Show("Existe la posibilidad de que tenga deficiencia de color visual. " + Resultado, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nota = "Deficiencia de color visual";
            }
            InsertRespuestas();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.Visible = true;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox2.Visible = true;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.Visible = true;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
            pictureBox5.Visible = true;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            pictureBox6.BringToFront();
            pictureBox6.Visible = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.Visible = true;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox2.Visible = true;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.Visible = true;
        }
       

        private void textBox6_KeyDown_1(object sender, KeyEventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
        }

        private void textBox5_KeyDown_1(object sender, KeyEventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.Visible = true;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        public void InsertRespuestas() //metodo para insertar datos acerca del ejercicio
        {
            IDUser = DBValue.valID; //Obtiene el ID del usuario actual

            //cadena la cual es un comando de sql para insertar datos dentro de la tabla Ejercicio_Vision_Color
            string query = "INSERT INTO Ejercicio_Vision_Color ('Id_Usuario', 'Fecha_Hora', 'Porcentaje_Aciertos', 'Nota') VALUES (@IDU, @Timestamp, @Re, @Nt)";
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
