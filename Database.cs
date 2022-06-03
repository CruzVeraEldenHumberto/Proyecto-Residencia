using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Therapheye
{
    class Database
    {
        public string Mensaje; //un simple mensaje
        public string Datetime; //variable de texto para la fecha_hora
        public SQLiteConnection myConnection; //implementación de DbConnection por parte de SQL
        public Database() //constructor de la clase de la base de datos
        {
            myConnection = new SQLiteConnection("Datasource = BDTherapheye.db");  //inicializa la conexión con la cadena especificada
            if (!File.Exists("./BDTherapheye.db")) //si el archivo de la base de datos no existe arroja un mensaje acerca de ello
            {
                Mensaje = "No existe una base de datos";
            }
        }

        public void OpenConnection() //metodo para abrir la conexión de la base de datos
        {
            if (myConnection.State != System.Data.ConnectionState.Open) //si la conexión es distinta a abierta (esta cerrada)
            {
                myConnection.Open(); //abre la conexión de la base de datos
            }
        }

        public void CloseConnection() //metodo apra cerrar la conexión de la base de datos
        {
            if (myConnection.State != System.Data.ConnectionState.Closed) //si la conexión es distinta a cerrada (esta abierta)
            {
                myConnection.Close(); //cierra la conexión de la base de datos
            }
        }

        public string GetDateTime() //metodo para obtener la fecha y hora actual
        {
            var datet = DateTime.Now; //variable que obtiene de valor la fecha y hora actualS
            Datetime = datet.ToString("MM/dd/yyyy h:mm tt"); //se formatea la fecha y hora de la manera especificada
            return Datetime; //retorna la variable Datetime
        }
    }
}
