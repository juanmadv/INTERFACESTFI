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

            if (puser.Email.Equals("ADMIN") && puser.Pass.Equals("ADMIN"))
                /*logica de login*/
                
                return new Patente("Administracion", "Administracion general de la aplicacion");
            else
                return null;
            

        }

        public void IniciarBase (string pserver, string puser, string ppwd)
        {

            try
            {
                Acceso.CrearAcceso(pserver, puser, ppwd);
            }
            catch (Exception ex)
            {

                throw ex;
            }                       

        }
        public bool Inicio()
        {
            bool check = false;
            try
            {                
              check =   Acceso.CheckAccess();
            }
            catch (Exception ex )
            {

                throw ex; 
                
            }
            return check;

        }

        public bool StartBkUp(string path1, string path2)
        {
           
            try
            {
                Acceso.ExecuteEscalar("SP_BACKUP",new System.Data.SqlClient.SqlParameter("@DIR1", path1),new System.Data.SqlClient.SqlParameter("@DIR2", path2));
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
                return false;
            }
            

        }

    }
}
