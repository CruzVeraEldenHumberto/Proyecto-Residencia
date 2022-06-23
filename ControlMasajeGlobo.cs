using System;
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
using System.Data.SQLite;

namespace Therapheye
{
    public partial class ControlMasajeGlobo : UserControl
    {
        Stopwatch reloj = new Stopwatch();
        public int IDUser; //id del usuario
        public string Datetime; //variable datetime para obtener fecha actual
        Database databaseobject = new Database();
        public string cambio;
        public string tipoEjercicio;
        public string DTNow;
        string tiempo;
        string Nota;

        public ControlMasajeGlobo()
        {
            InitializeComponent();
        }

        private void ControlMasajeGlobo_Load(object sender, EventArgs e)
        {
            txtSeg.Text = "00";
            txtMil.Text = "000";
            pictureBox1.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\masajeGlobo.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reloj.Start();
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan ts = reloj.Elapsed;
            tiempo = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //tiempo = reloj.Elapsed.ToString();
            reloj.Reset();

            //MessageBox.Show(tiempo);

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
            tipoEjercicio = "Masaje en globos oculares";

            string query = "INSERT INTO Ejercicio_Presion ('Id_Usuario', Tipo_Ejercicio, 'Fecha_Hora', 'Tiempo_Ejercicio', 'Cambio', 'Nota') VALUES (@IDU, @Tipo, @Timestamp, @TiempoE, @Cambio, @Nota)";
            SQLiteCommand mycommand = new SQLiteCommand(query, databaseobject.myConnection);

            databaseobject.OpenConnection();

            DTNow = databaseobject.GetDateTime();

            mycommand.Parameters.AddWithValue("@IDU", IDUser);
            mycommand.Parameters.AddWithValue("@Tipo", tipoEjercicio);
            mycommand.Parameters.AddWithValue("@Timestamp", DTNow);
            mycommand.Parameters.AddWithValue("@TiempoE", tiempo);
            mycommand.Parameters.AddWithValue("@Cambio", cambio);
            mycommand.Parameters.AddWithValue("@Nota", Nota);

            mycommand.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reloj.Reset();
            FormPresion.ActiveForm.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)reloj.ElapsedMilliseconds);

            //txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            txtMil.Text = ts.Milliseconds.ToString();


            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\ring.wav");
            System.Media.SoundPlayer toca = new System.Media.SoundPlayer("ring.wav");
            if (ts.Seconds == 15) { player.Play(); }
            if (ts.Seconds == 30) { player.Play(); reloj.Reset(); }
        }

        private void ControlMasajeGlobo_Leave(object sender, EventArgs e)
        {
            reloj.Reset();
        }
    }
}
