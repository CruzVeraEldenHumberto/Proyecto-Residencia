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
    public partial class FormProgreso : Form
    {
        Database databaseobject = new Database(); //crea un objeto de la clase Database para ayudar con la conexion a la base de datos

        public FormProgreso()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormProgreso.ActiveForm.Close(); //cierra el formulario actual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mueve el sidepanel para especificar que boton esta seleccionado
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            databaseobject.OpenConnection(); //se abre la conexion a la base de datos

            //string el cual es un comando sql de tipo select, selecciona ciertas columnas de la tabla Ejercicio_Constraste_Sensibilidad donde el ID es igual al del Usuario
            string CommandText = "SELECT Fecha_Hora, Primer_Respuesta, Segunda_Respuesta, Tercer_Respuesta, Cuarta_Respuesta, Quinta_Respuesta, Sexta_Respuesta, Septima_Respuesta, Octava_Respuesta FROM Ejercicio_Contraste_Sensibilidad WHERE Id_Usuario = 1";

            //crea un data adapter
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, databaseobject.myConnection);
            DataTable dt;

            using (dt = new DataTable())
            {
                sqlda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            SetColumnProperties();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            databaseobject.OpenConnection();
            string CommandText = "SELECT Fecha_Hora, Primer_Respuesta, Segunda_Respuesta, Tercer_Respuesta, Cuarta_Respuesta, Quinta_Respuesta, Sexta_Respuesta FROM Ejercicio_Vision_Color WHERE Id_Usuario = 1";
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, databaseobject.myConnection);
            DataTable dt;

            using (dt = new DataTable())
            {
                sqlda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            SetColumnProperties();
        }

        public void SetColumnProperties()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 117, 237);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            databaseobject.OpenConnection();
            string CommandText = "SELECT Tipo_Ejercicio, Fecha_Hora,  Tiempo_Ejercicio, Cambio FROM Ejercicio_Presion WHERE Id_Usuario = 1";
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, databaseobject.myConnection);
            DataTable dt;

            using (dt = new DataTable())
            {
                sqlda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            SetColumnProperties();
        }
    }
}
