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
        public string Mensaje;
        public string Datetime;
        public SQLiteConnection myConnection;
        public Database()
        {
            myConnection = new SQLiteConnection("Datasource = BDTherapheye.db");
            if (!File.Exists("./BDTherapheye.db"))
            {
                Mensaje = "No existe una base de datos";
            }
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        public string GetDateTime()
        {
            var datet = DateTime.Now;
            Datetime = datet.ToString("MM/dd/yyyy h:mm tt");
            return Datetime;
        }
    }
}
