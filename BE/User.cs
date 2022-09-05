using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {

        #region constructores
        public User(string nombre, string apellido, string dNI)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            

        }
        #endregion

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        private List<Familia> _familia = new List<Familia>();


    }
}
