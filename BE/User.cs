using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace BE
{
    public class User
    {

        #region constructores
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dNI"></param>
        /// <param name="pemail"></param>
        /// <param name="ppass"></param>
        /// <param name="pblocked"></param>
        public User(string nombre, string apellido, string dNI, string pemail, string ppass, bool pblocked)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Email = pemail;
            Pass = ppass;
            Blocked = pblocked;
        }


        public User( string pemail, string ppass)
        {
            
            Email = pemail;
            Pass = ppass;
           
        }



        #endregion

        #region propertys
        [Columna("Id")]
        public int Id { get; set; }
        [Columna("Nombre")]
        public string Nombre { get; set; }
        [Columna("Apellido")]
        public string Apellido { get; set; }
        [Columna("DNI")]
        public string DNI { get; set; }
        [Columna("Email")]
        public string Email { get; set; }
        [Columna("Pass")]
        public string Pass { get; set; }
        [Columna("Blocked")]
        public bool Blocked { get; set; }


        /// <summary>
        /// Property para representar la tabla intermedia UsuarioFamilia
        /// </summary>
        [Columna("IdFamilia")]
        public int idFamilia { get; set; }

        #endregion

        private List<Familia> _familia = new List<Familia>();


        public override string ToString()
        {
            return Reflex.GetInstance().GetString(this);
        }

    }
}
