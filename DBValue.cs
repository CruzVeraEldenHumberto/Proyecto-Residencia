using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therapheye
{
    public class DBValue //clase que ayuda en la obtención y utilización del id del usuario actual de la base de datos
    {
        public static int valID; //variable entera estatica valID

        public void Asignar(int val) //metodo para asignar el valor recibido a la variable estatica
        {
            valID = val;
        }

    }
}
