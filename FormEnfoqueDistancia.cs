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
    public partial class FormEnfoqueDistancia : Form
    {
        public int IDUser; //id del usuario
        public string Datetime; //variable datetime para obtener fecha actual
        Database databaseobject = new Database();
        public string cambio;
        public string tipoEjercicio;
        public string DTNow;
        public string Nota;

        public FormEnfoqueDistancia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEnfoqueDistancia.ActiveForm.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Comenzar")
            {
                button2.Text = "Finalizar";
            }

            else
            {
                button2.Text = "Comenzar";

                if (MessageBox.Show("¿Siente algún cambio en su vista?", "Test", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                IDUser = DBValue.valID;
                tipoEjercicio = "Enfoque a distancia";

                string query = "INSERT INTO Ejercicio_Enfoque_Distancia ('Id_Usuario', Tipo_Ejercicio, 'Fecha_Hora', 'Cambio', 'Nota') VALUES (@IDU, @Tipo, @Timestamp, @Cambio, @Nota)";
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
}
