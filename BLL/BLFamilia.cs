using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLFamilia
    {
        #region Constructores
        public BLFamilia() { }



        #endregion

        #region Propertys

        PatenteColecction _Patentes;


        #endregion


        #region Methods
        /// <summary>
        /// metodo para obtener el resto de las patentes de la familia
        /// </summary>
        /// <param name="patente"></param>
        /// <returns></returns>
        public List<Patente> GetPatentes(Patente patente)
        {
            return _Patentes.Where(x => x.Nombre.Equals(patente.Nombre)).ToList();


        }

        #endregion

    }
}
