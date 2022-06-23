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
    public partial class ControlAlternar : UserControl
    {
        public int IDUser; //id del usuario
        public string Datetime; //variable datetime para obtener fecha actual
        Database databaseobject = new Database();
        public string cambio;
        public string tipoEjercicio;
        public string DTNow;
        public string Nota;

        public ControlAlternar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMov.ActiveForm.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void ControlAlternar_Load(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\cuchara.gif");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Detener")
            {
                button1.Text = "Iniciar";
                if(MessageBox.Show("¿Siente algún cambio en su vista?", "Test", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    cambio = "Sí";
                    using (FormMensaje formmen = new FormMensaje())
                    {
                        if (formmen.ShowDialog() == DialogResult.OK)
                        {
                            Nota = formmen.valorMensaje;
                        }
                    }
                }
                else
                {
                    cambio = "No";
                    Nota = "-";
                }
                InsertarDatos();
            }
            else
            {
                button1.Text = "Detener";
            }
        }


        public void InsertarDatos()
        {
            IDUser = DBValue.valID;
            tipoEjercicio = "Alternar vista";

            string query = "INSERT INTO Ejercicio_Movimiento_Ocular ('Id_Usuario', Tipo_Ejercicio, 'Fecha_Hora', 'Cambio', 'Nota') VALUES (@IDU, @Tipo, @Timestamp, @Cambio, @Nota)";
            SQLiteCommand mycommand = new SQLiteCommand(query, databaseobject.myConnection);

            databaseobject.OpenConnection();

            DTNow = databaseobject.GetDateTime();

            mycommand.Parameters.AddWithValue("@IDU", IDUser);
            mycommand.Parameters.AddWithValue("@Tipo", tipoEjercicio);
            mycommand.Parameters.AddWithValue("@Timestamp", DTNow);
            mycommand.Parameters.AddWithValue("@Cambio", cambio);
            mycommand.Parameters.AddWithValue("@Nota", Nota);

            mycommand.ExecuteNonQuery();

            databaseobject.CloseConnection();
        }
    }
}
