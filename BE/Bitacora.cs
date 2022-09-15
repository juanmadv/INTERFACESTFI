using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;


namespace BE
{
    public class Bitacora:IPersistible
    {
        #region Constructor
        public Bitacora() { }
        public Bitacora(User pusuario, int criticidad, string descripcion, DateTime pfecha)
        {
            IdUSer = pusuario.Id;
            Usuario = pusuario;
            Criticidad = criticidad;
            Descripcion = descripcion;
            Fecha = pfecha;
        }
        #endregion

        #region Atributos
        //[Columna("Id")]        
        public int Id { get; set; }
        [Columna("IdUser")]
        public int IdUSer { get; private set; }

        public User Usuario { get; set; }

        [Columna("Criticidad")]
        public int Criticidad { get; set; }
        [Columna("Descripcion")]
        public string Descripcion{ get; set; }
        [Columna("Fecha")]
        public DateTime Fecha { get; set; }

        [Columna("DVH")]
        public int DVH{ get; set; }
        #endregion


        override public string ToString()
        {
            return Reflex.GetInstance().GetString(this);
        }

    }
}
