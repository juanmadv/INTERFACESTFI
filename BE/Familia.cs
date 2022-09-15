using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace BE
{
    class Familia:IPersistible
    {
        public Familia(string pNombre, bool pHabilitado )
        {
            Nombre = pNombre;
            Habilitado = pHabilitado;
        }

        private List<Patente> _patentes = new List<Patente>();

        #region propertys

        /// <summary>
        /// Property para representar la tabla intermedia FamiliaPatente
        /// </summary>
        [Columna("IdPatentes")]
        public int IdPatentes { get; set; }

        [Columna("Nombre")]
        public string Nombre { get; set; }

        [Columna("Habilitado")]
        public bool Habilitado { get; set; }
        #endregion

        public void AddPatente(Patente ppatente)
        {
            //validar duplicados
            this._patentes.Add(ppatente);
        }

        public IReadOnlyCollection<Patente> GetPatentes()
        {
            return _patentes.AsReadOnly();
        }

        public override string ToString()
        {
            return Reflex.GetInstance().GetString(this);
        }

        

    }



    

}
