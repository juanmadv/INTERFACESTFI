using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patente : IPersistible
    {
        #region Constructores
        public Patente(string pnombre, string pdescrip)
        {
            Nombre = pnombre;
            Descripcion = pdescrip;

        }

        #endregion
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }


    }
}
