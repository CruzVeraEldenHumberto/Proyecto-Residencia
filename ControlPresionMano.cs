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
    public partial class ControlPresionMano : UserControl
    {

        Stopwatch reloj = new Stopwatch();
        string tiempo;
        public int IDUser; //id del usuario
        public string Datetime; //variable datetime para obtener fecha actual
        Database databaseobject = new Database();
        public string cambio;
        public string tipoEjercicio;
        public string DTNow;


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
            tiempo = reloj.Elapsed.ToString();
            reloj.Reset();

            if (MessageBox.Show("¿Siente algún cambio en su vista?", "Test", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                cambio = "Sí";
            }
            else
            {
                cambio = "No";
            }


            DBValue idval = new DBValue();
            IDUser = idval.IDValue(1);
            tipoEjercicio = "Presión con la mano";

            string query = "INSERT INTO Ejercicio_Presion ('Id_Usuario', Tipo_Ejercicio, 'Fecha_Hora', 'Tiempo_Ejercicio', 'Cambio') VALUES (@IDU, @Tipo, @Timestamp, @TiempoE, @Cambio)";
            SQLiteCommand mycommand = new SQLiteCommand(query, databaseobject.myConnection);

            databaseobject.OpenConnection();

            DTNow = databaseobject.GetDateTime();

            mycommand.Parameters.AddWithValue("@IDU", IDUser);
            mycommand.Parameters.AddWithValue("@Tipo", tipoEjercicio);
            mycommand.Parameters.AddWithValue("@Timestamp", DTNow);
            mycommand.Parameters.AddWithValue("@TiempoE", tiempo);
            mycommand.Parameters.AddWithValue("@Cambio", cambio);

            mycommand.ExecuteNonQuery();

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
