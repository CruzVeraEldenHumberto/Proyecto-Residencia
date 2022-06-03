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
        DBValue dbval = new DBValue(); //se crea un objeto de la clase DBValue
        public int idVal; //variable que tiene como valor el id del usuario actual como numero entero
        public string aux; //variable que tiene como valor el id del usuario actual como string

        public FormProgreso()
        {
            InitializeComponent();
            idVal = DBValue.valID; //asigna el valor de la variable estatic valID a idVal
            aux = idVal.ToString(); //convierte el valor de idVal a una cadena y lo asigna a la variable aux
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormProgreso.ActiveForm.Close(); //cierra el formulario actual
            databaseobject.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarPanel();
            //mueve el sidepanel para especificar que boton esta seleccionado
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            databaseobject.OpenConnection(); //se abre la conexion a la base de datos

            //string el cual es un comando sql de tipo select, selecciona ciertas columnas de la tabla Ejercicio_Constraste_Sensibilidad donde el ID 
            //es igual al del Usuario
            string CommandText = "SELECT Fecha_Hora, Porcentaje_Aciertos, Nota FROM Ejercicio_Contraste_Sensibilidad WHERE Id_Usuario='" + aux + "'";

            //crea un data adapter en base al comando anterior y la conexion
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, databaseobject.myConnection);
            DataTable dt; //crea una datatable

            //utilizando el datatable anterior
            using (dt = new DataTable())
            {
                sqlda.Fill(dt); //llena el databletable en base a la datos del data adapter
                dataGridView1.DataSource = dt; //llena el datagridview en base a los datos de la datatable
            }

            SetColumnProperties();
            databaseobject.CloseConnection(); //cierra la conexión de la base de datos
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarPanel();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            databaseobject.OpenConnection();
            string CommandText = "SELECT Fecha_Hora, Porcentaje_Aciertos, Nota FROM Ejercicio_Vision_Color WHERE Id_Usuario='" + aux + "'"; ;
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, databaseobject.myConnection);
            DataTable dt;

            using (dt = new DataTable())
            {
                sqlda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            SetColumnProperties();
            databaseobject.CloseConnection();
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
            MostrarPanel();
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            databaseobject.OpenConnection();
            string CommandText = "SELECT Tipo_Ejercicio, Fecha_Hora,  Tiempo_Ejercicio, Cambio FROM Ejercicio_Presion WHERE Id_Usuario='" + aux + "'";
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, databaseobject.myConnection);
            DataTable dt;

            using (dt = new DataTable())
            {
                sqlda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            SetColumnProperties();
            databaseobject.CloseConnection();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            dataGridView1.Visible = false;
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            dataGridView1.Visible = false;
            panel2.Visible = true;

            databaseobject.OpenConnection(); //se abre una conexion a la base de datos
            string CommandText = "SELECT * FROM Cuestionario_Inicial WHERE ID_Usuario='" + aux + "'";

            //se ejecuta la consulta anterior
            SQLiteCommand mycommand = new SQLiteCommand(CommandText, databaseobject.myConnection);
            SQLiteDataReader sqReader = mycommand.ExecuteReader(); // se crea un objetoSQLiteDataReader para leer los datos de la tabla

            if (sqReader.Read()) //mientras se lean los datos
            {
                //si se encuentra un usuario existente, se asiga el valor de su id a la variable
                label1.Text = sqReader["Diagnostico"].ToString();
                label2.Text = sqReader["Fecha_Hora"].ToString();
            }

            else
            {
                sqReader.Close();
            }
            databaseobject.CloseConnection();
        }

        public void MostrarPanel()
        {
            dataGridView1.Visible = true;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarPanel();
            //mueve el sidepanel para especificar que boton esta seleccionado
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            databaseobject.OpenConnection(); //se abre la conexion a la base de datos
            string CommandText = "SELECT Tipo_ejercicio, Fecha_Hora, Cambio FROM Ejercicio_Enfoque_Distancia WHERE Id_Usuario='" + aux + "'";
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, databaseobject.myConnection);
            DataTable dt;

            using (dt = new DataTable())
            {
                sqlda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            SetColumnProperties();
            databaseobject.CloseConnection();
        }
    }
}
