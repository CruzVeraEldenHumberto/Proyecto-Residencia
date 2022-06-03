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
        public int idVal; //ID del usuario que intenta iniciar sesión
        Database databaseobject = new Database(); //se crea un objeto de la base de datos
        DBValue dbval = new DBValue(); //crea un objeto de la clase DBValue
        public string Prueba; //variable string del ID del usuario que intenta iniciar sesion
        public bool UserSuccessfullyAuthenticated { get; private set; } //variable booleana para especificar si se autentico el inicio de sesión

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
                    idVal = int.Parse(Prueba); //convierte la cadena en un entero y se le asigna el valor a la variable idVal
                    dbval.Asignar(idVal); //manda a llamar el metodo asignar con el parametro idVal
                    sqReader.Close(); //cierra el sqldatareader
                    UserSuccessfullyAuthenticated = true; //el valor es verdadero ya que se pudo autenticar el usuario
                    databaseobject.CloseConnection(); //cierra la conexión de la base de datos
                    this.Close();//cierra el formulario actual               
                }

                else
                {
                    sqReader.Close(); //cierra el lector de datos
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nombre";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.Silver;
            }
        }
    }
}
