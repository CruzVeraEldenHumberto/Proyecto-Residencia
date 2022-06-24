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
            string CommandText = "SELECT Fecha_Hora, Tipo_Ejercicio, Tiempo_Ejercicio, Cambio, Nota FROM Ejercicio_Presion WHERE Id_Usuario='" + aux + "'";
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, databaseobject.myConnection);
            DataTable dt;

            using (dt = new DataTable())
            {
                sqlda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns["Fecha_Hora"].DisplayIndex = 0;
            dataGridView1.Columns["Tipo_Ejercicio"].DisplayIndex = 1;
            dataGridView1.Columns["Tiempo_Ejercicio"].DisplayIndex = 2;
            dataGridView1.Columns["Cambio"].DisplayIndex = 3;
            dataGridView1.Columns["Nota"].DisplayIndex = 4;
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
            string CommandText = "SELECT * FROM Cuestionario_Inicial WHERE ID_Usuario= @ID";

            //se ejecuta la consulta anterior
            SQLiteCommand mycommand = new SQLiteCommand(CommandText, databaseobject.myConnection);
            mycommand.Parameters.AddWithValue("@ID", aux);
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

            databaseobject.OpenConnection(); //se abre una conexion a la base de datos
            string CommandTextFinal = "SELECT * FROM Cuestionario_Final WHERE ID_Usuario= @ID";

            //se ejecuta la consulta anterior
            SQLiteCommand mycommandf = new SQLiteCommand(CommandTextFinal, databaseobject.myConnection);
            mycommandf.Parameters.AddWithValue("@ID", aux);
            SQLiteDataReader sqReaderf = mycommandf.ExecuteReader(); // se crea un objetoSQLiteDataReader para leer los datos de la tabla

            if (sqReaderf.Read()) //mientras se lean los datos
            {
                //si se encuentra un usuario existente, se asiga el valor de su id a la variable
                label4.Text = sqReaderf["Diagnostico"].ToString();
                label3.Text = sqReaderf["Fecha_Hora"].ToString();
            }

            else
            {
                label4.Text = "No se ha realizado el test final";
                label3.Text = "Sin fecha disponible";
                sqReaderf.Close();
            }

            string CommandTextUserD = "SELECT * FROM Usuario WHERE ID= @ID";

            //se ejecuta la consulta anterior
            SQLiteCommand mycommandUser = new SQLiteCommand(CommandTextUserD, databaseobject.myConnection);
            mycommandUser.Parameters.AddWithValue("@ID", aux);
            SQLiteDataReader sqReaderUser = mycommandUser.ExecuteReader(); // se crea un objetoSQLiteDataReader para leer los datos de la tabla

            if (sqReaderUser.Read()) //mientras se lean los datos
            {
                //si se encuentra un usuario existente, se asiga el valor de su id a la variable
                textBox1.Text = sqReaderUser["Nombre"].ToString();
                textBox2.Text = sqReaderUser["Direccion"].ToString();
                textBox3.Text = sqReaderUser["Telefono"].ToString();
                textBox4.Text = sqReaderUser["Correo"].ToString();
                textBox5.Text = sqReaderUser["Password"].ToString();
            }

            else
            {
                sqReaderUser.Close();
            }

            databaseobject.CloseConnection();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            databaseobject.OpenConnection(); //se abre una conexion a la base de datos
            string CommandText = "SELECT * FROM Usuario WHERE ID= @ID";
            SQLiteCommand mycommandGet = new SQLiteCommand(CommandText, databaseobject.myConnection);
            mycommandGet.Parameters.AddWithValue("@ID", aux);
            SQLiteDataReader sqReaderUP = mycommandGet.ExecuteReader(); // se crea un objetoSQLiteDataReader para leer los datos de la tabla
            if (sqReaderUP.Read()) //mientras se lean los datos
            {
                sqReaderUP.Close();
                string queryupdate = "UPDATE Usuario set Nombre = @Name, Direccion = @Direc, Telefono = @Tel, Correo = @Mail, Password = @Pass WHERE ID = @IDU";
                SQLiteCommand myupcommand = new SQLiteCommand(queryupdate, databaseobject.myConnection);

                myupcommand.Parameters.AddWithValue("@IDU", aux);
                myupcommand.Parameters.AddWithValue("@Name", textBox1.Text);
                myupcommand.Parameters.AddWithValue("@Direc", textBox2.Text);
                myupcommand.Parameters.AddWithValue("@Tel", textBox3.Text);
                myupcommand.Parameters.AddWithValue("@Mail", textBox4.Text);
                myupcommand.Parameters.AddWithValue("@Pass", textBox5.Text);
                myupcommand.ExecuteNonQuery();
                databaseobject.CloseConnection();
            }

            else
            {
                sqReaderUP.Close();
                databaseobject.CloseConnection();
            }
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
            string CommandText = "SELECT Tipo_ejercicio, Fecha_Hora, Cambio, Nota FROM Ejercicio_Enfoque_Distancia WHERE Id_Usuario='" + aux + "'";
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

        private void button10_Click(object sender, EventArgs e)
        {
            MostrarPanel();
            //mueve el sidepanel para especificar que boton esta seleccionado
            SidePanel.Height = button10.Height;
            SidePanel.Top = button10.Top;

            databaseobject.OpenConnection(); //se abre la conexion a la base de datos
            string CommandText = "SELECT Tipo_Ejercicio, Fecha_Hora, Cambio, Nota FROM Ejercicio_Movimiento_Ocular WHERE Id_Usuario='" + aux + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarPanel();
            //mueve el sidepanel para especificar que boton esta seleccionado
            SidePanel.Height = button10.Height;
            SidePanel.Top = button10.Top;

            databaseobject.OpenConnection(); //se abre la conexion a la base de datos
            string CommandText = "SELECT Tipo_Ejercicio, Fecha_Hora, Cambio, Nota FROM Ejercicio_Integridad_Ocular WHERE Id_Usuario='" + aux + "'";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
