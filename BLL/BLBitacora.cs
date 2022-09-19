using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
namespace BLL
{
    public class BLBitacora
    {
        private BitacoraMapper mapper;

        private BitacoraMapper GetMapper()
        {
            if (mapper == null)
                return new BitacoraMapper();
            else
                return mapper;
        }
        public void Grabar(User pusuario, int pcriticidad, string pdescripcion, DateTime pfecha, string phost)
        {
           Bitacora be = new Bitacora(pusuario, pcriticidad, pdescripcion, pfecha, phost);

            try
            {
                GetMapper().Crear(be);
            }
            catch (Exception e)
            {

                throw e ;
            }

        }


        public List<Bitacora> GetAll()
        {
            try
            {
               return GetMapper().ListAll();
            }
            catch (Exception e)
            {

                throw e;
            }
            return null;


        }
    }
}
