using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Constantes;

namespace DAL
{
    public static class Acceso
    {



        private static string _ConexionBD;//= ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

        private static SqlConnection Conexion = new SqlConnection(GetConexion());

        private static SqlCommand MSqlCommand = Conexion.CreateCommand();

        private static SqlConnectionStringBuilder sqlConnBuilder = new SqlConnectionStringBuilder();

        private static string GetConexion()
        {
            try
            {
              //  return ConfigurationManager.ConnectionStrings[Constantes.NOMBRECONEXION].ConnectionString;
              return   EncryptorMan.Desencrypt();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static string ManageConnection()
        {
           // Desencrypt();
            Conexion.Open();

            try
            {

                if (Conexion.State == System.Data.ConnectionState.Closed)
                {
                    Conexion.Open();
                    return Conexion.State.ToString();
                }
                else
                {
                    Conexion.Close();
                    return Conexion.State.ToString();
                }
            }
            catch (Exception e)
            {

                throw new Exception(" no se pudo establecer la conexion con la base de datos: \n" + GetConexion() + e.Message);
            }
        }

        public static bool CheckAccess()
        {
            try
            {
                Conexion.Open();
                
                return true;
            }
            catch (Exception)
            {
                //return false;
                throw;
            }
            finally
            {
                Conexion.Close();
            }
        }

        private static bool CheckAccess(string CON)
        {
            SqlConnection mConexion = new SqlConnection(CON);
            try
            {                
                mConexion.Open();
                return true;
            }
            catch (Exception)
            {
                //return false;
                throw new Exception("error de conexion con esta conexion:" + mConexion.ConnectionString);
            }
        }




        public static void CrearAcceso(string pserver , string puser, string ppwd)
        {          
            
            sqlConnBuilder.InitialCatalog = Constantes.BASE;
            sqlConnBuilder.DataSource = pserver;
            sqlConnBuilder.IntegratedSecurity = false;
            sqlConnBuilder.UserID = puser;
            sqlConnBuilder.Password = ppwd;
            bool check = false;
            try
            {
                 //check = CheckAccess(sqlConnBuilder.ConnectionString);

            }
            catch (Exception)
            {

                throw;
            }

            //if (check)
                EncryptorMan.EncryptAndSave(sqlConnBuilder.ConnectionString);
            //else
            //    throw new Exception("no se puede establecer la conexion");

        }

    }
    
}
