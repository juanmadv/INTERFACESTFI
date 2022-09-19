using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;


namespace BE
{
    public class Bitacora : IPersistible
    {
        #region Constructor
        public Bitacora() { }
        public Bitacora(User pusuario, int pcriticidad, string pdescripcion, DateTime pfecha, string phost)
        {
            //IdUSer = pusuario.Id;
            IdUSer = 1;
            Usuario = pusuario;
            Criticidad = pcriticidad;
            Descripcion = pdescripcion;
            Fecha = pfecha;
            this.Host = phost;
        }
        #endregion

        #region Atributos
        [Columna("Id")]
        public int Id { get; set; }
        [Columna("Descripcion")]
        public string Descripcion { get; set; }

        public User Usuario { get; set; }

        [Columna("Criticidad")]
        public int Criticidad { get; set; }

        [Columna("Fecha")]
        public DateTime Fecha { get; set; }

        [Columna("IdUser")]
        public int IdUSer { get; private set; }
        
        
        
        [Columna("DVH")]
        public int DVH { get; set; }
        [Columna("Host")]

        public String Host { get; set; }
        #endregion

        override public string ToString()
        {
            return Reflex.GetInstance().GetString(this);
        }

    }
}
