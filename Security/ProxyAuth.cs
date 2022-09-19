using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using BLL;
namespace Security
{
    public class ProxyAuth
    {
        #region Constructores
        public ProxyAuth() { }
        #endregion

        #region Variables

        private User _userAuth;
        private BLBitacora bitacora;


        private BLBitacora GetBitacora()
        {
            if (bitacora == null)
            { bitacora = new BLBitacora(); 
            }

            return bitacora;
        }
        #endregion


        public Patente Login(User puser, string pass, string pHost)
        {
            this._userAuth = puser;

            try
            {
                GetBitacora().Grabar(_userAuth, 1, "intento de login", DateTime.Now, pHost);
            }
            catch (Exception e)
            {

                throw e;
            }
            

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
        public static bool InicioAsync()
        {
            bool check = false;
            
            try
            {                
               check = Acceso.CheckAccess();
                
                return check;
                
            }
            catch (Exception ex )
            {

                throw ex; 
                
            }            

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


        public List<Bitacora> ListarBitacora()
        {
            return GetBitacora().GetAll();
        }

    }
}
