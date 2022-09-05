using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace Security
{
    public class ProxyAuth
    {
        #region Constructores
        public ProxyAuth() { }
        #endregion

        #region Variables

        private User _userAuth;

        #endregion


        public Patente Login(User puser, string pass)
        {
            this._userAuth = puser;
            
            /*logica de login*/
            return null;

        }

        public void inicio (string pserver, string puser, string ppwd)
        {

            try
            {
                Acceso.CrearAcceso(pserver, puser, ppwd);
            }
            catch (Exception)
            {

                throw;
            }                       

        }
        public string inicio()
        {
            string check = null;
            try
            {
                //return EncryptorMan.Desencrypt();
              check =   Acceso.ManageConnection();
            }
            catch (Exception )
            {

                throw;
                
            }
            return check;

        }


    }
}
