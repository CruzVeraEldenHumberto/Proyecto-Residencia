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
    public partial class Login : Form
    {
        public int idVal;
        Database databaseobject = new Database();
        DBValue dbval = new DBValue();
        public int aux;
        public string Prueba;
        public bool UserSuccessfullyAuthenticated { get; private set; }

        public Login()
        {
            InitializeComponent();
            //cambia la imagen actual del picturebox por una nueva
            pictureBox1.Image = Image.FromFile(@"..\..\..\..\Residencia\Proyecto-Residencia\Resources\user.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validar(); //llamada de metodo
        }

        public void Validar() //metodo para validar si el usuario es correcto
        {
            databaseobject.OpenConnection(); //se abre una conexion a la base de datos
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty) //si ambos campos no son nulos
            {
                //se hace una consulta select para buscar el usuario con los datos ingresados
                string CommandText = "SELECT * FROM Usuario WHERE Nombre='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";

                //se ejecuta la consulta anterior
                SQLiteCommand mycommand = new SQLiteCommand(CommandText, databaseobject.myConnection);
                SQLiteDataReader sqReader = mycommand.ExecuteReader(); // se crea un objetoSQLiteDataReader para leer los datos de la tabla

                if(sqReader.Read()) //mientras se lean los datos
                {
                    //si se encuentra un usuario existente, se asiga el valor de su id a la variable
                    Prueba = sqReader["ID"].ToString();
                    idVal = int.Parse(Prueba);
                    dbval.Asignar(idVal);
                    sqReader.Close(); //cierra el sqldatareader
                    UserSuccessfullyAuthenticated = true;
                    this.Close();//cierra el formulario actual               
                }

                else
                {
                    sqReader.Close();
                    MessageBox.Show("No existe una cuenta con los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                databaseobject.CloseConnection(); //se cierra conexion de la base de datos
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormRegistro fr = new FormRegistro();
            fr.ShowDialog();
        }
    }
}
