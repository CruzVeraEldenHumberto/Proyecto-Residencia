using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therapheye
{
    public class DBValue
    {
        public static int valID;
        public int idValor;
        public int IDValue(int idvalue)
        {
            return idvalue;
        }

        public void Asignar(int val)
        {
            idValor = val;
            valID = val;
        }

        public int retValor()
        {
            return idValor;
        }
    }
}
