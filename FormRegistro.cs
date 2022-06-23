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
    public partial class FormRegistro : Form
    {
        Database databaseobject = new Database();

        public bool UserLogin { get; private set; }
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty || textBox4.Text != string.Empty || textBox5.Text != string.Empty)
            {
                databaseobject.OpenConnection();
                //string CommandText = "SELECT * FROM Usuario WHERE Nombre='" + textBox1.Text + "'";
                string CommandText = "SELECT * FROM Usuario WHERE Nombre= @NombreU";
                SQLiteCommand mycommand = new SQLiteCommand(CommandText, databaseobject.myConnection);
                mycommand.Parameters.AddWithValue("@NombreU", textBox1.Text);
                SQLiteDataReader sqReader = mycommand.ExecuteReader(); // se crea un objetoSQLiteDataReader para leer los datos de la tabla
                if (sqReader.Read()) //mientras se lean los datos
                {
                    sqReader.Close();
                    MessageBox.Show("Este usuario ya existe, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    sqReader.Close();

                    string query = "INSERT INTO Usuario ('Nombre', 'Direccion', 'Telefono', 'Correo', 'Password') VALUES (@Name, @Dir, @Tel, @Mail, @Pass)";
                    SQLiteCommand myscommand = new SQLiteCommand(query, databaseobject.myConnection);

                    myscommand.Parameters.AddWithValue("@Name", textBox1.Text);
                    myscommand.Parameters.AddWithValue("@Dir", textBox2.Text);
                    myscommand.Parameters.AddWithValue("@Tel", textBox3.Text);
                    myscommand.Parameters.AddWithValue("@Mail", textBox4.Text);
                    myscommand.Parameters.AddWithValue("@Pass", textBox5.Text);

                    myscommand.ExecuteNonQuery();
                    MessageBox.Show("Tu cuenta ha sido creado. Por favor inicia sesión.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    databaseobject.CloseConnection();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InsertarDatos()
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Teléfono")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Dirección")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Correo electrónico")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Contraseña")
            {
                textBox5.Text = "";
                textBox5.PasswordChar = '*';
                textBox5.ForeColor = Color.Black;
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

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Dirección";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Teléfono";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Correo electrónico";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.PasswordChar = '\0';
                textBox5.Text = "Contraseña";
                textBox5.ForeColor = Color.Silver;
            }
        }
    }
}
