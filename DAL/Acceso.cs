using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        private static SqlConnection Conexion = new SqlConnection();

        private static SqlCommand MSqlCommand = Conexion.CreateCommand();

        private static SqlConnectionStringBuilder sqlConnBuilder = new SqlConnectionStringBuilder();

        private static string GetConexion()
        {
            try
            {
                //if (Conexion.ConnectionString == null)
                //{ 
                    Conexion.ConnectionString = EncryptorMan.Desencrypt();
                //}

                return Conexion.ConnectionString;
            }

            catch (System.Configuration.ConfigurationException CONFEX)
            {
                throw new Exception("NO SE PUEDE DESENCRIPTAR LA CLAVE");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private static string ManageConnection()
        {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Closed)
                {
                    GetConexion();
                    Conexion.Open();
                    return Conexion.State.ToString();
                }
                else
                {
                    Conexion.Close();
                    return Conexion.State.ToString();
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {

                throw new Exception(" no se pudo establecer la conexion con la base de datos: \n" + GetConexion() + e.Message + e.StackTrace);
            }
        }


        public static DataTable ExecuteReader(string pcomando)
        {

            try
            {
                ManageConnection();
                MSqlCommand.CommandText = pcomando;

                DataTable mdt = new DataTable("tabla");

                SqlDataAdapter mDA = new SqlDataAdapter(pcomando, MSqlCommand.Connection);

                mDA.Fill(mdt);

                return mdt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                ManageConnection();
            }
        }





        public static int ExecuteNonQuery(string pcommandtext, List<SqlParameter> pparameters = null)
        {

            if (pparameters != null) { ManageParameters(pparameters); }

            try
            {
                ManageConnection();

                MSqlCommand.CommandType = CommandType.Text;
                MSqlCommand.Transaction = Conexion.BeginTransaction();
                MSqlCommand.CommandText = pcommandtext;
                string comando = MSqlCommand.CommandText.ToString();
                int result = MSqlCommand.ExecuteNonQuery();
                if (result == -1)
                {
                    MSqlCommand.Transaction.Rollback();
                }
                else if (result == 1 | result > 1)
                {
                    MSqlCommand.Transaction.Commit();
                }

                return result;

            }
            catch (Exception ex)
            {
                //throw new Exception(" no se pudo ejecutar la sentencia: \n" + MSqlCommand.CommandText + "\n error:" + ex.Message);
                throw new Exception(ex.Message + " query ejecutado " + MSqlCommand.CommandText);
            }
            finally
            {
                ManageConnection();
            }
        }


        public static object ExecuteEscalar(string pcommandtext, SqlParameter pparameter = null, SqlParameter PPARAMETER2 = null)
        {

            if (MSqlCommand.Parameters.Count>0)
                MSqlCommand.Parameters.Clear();
            if(pparameter!= null)
                MSqlCommand.Parameters.Add(pparameter);
            if (PPARAMETER2 != null)
                MSqlCommand.Parameters.Add(PPARAMETER2);

            try
            {
                ManageConnection();

                MSqlCommand.CommandType = CommandType.StoredProcedure;
               // MSqlCommand.Transaction = Conexion.BeginTransaction();
                MSqlCommand.CommandText = pcommandtext;
                string comando = MSqlCommand.CommandText.ToString();
                object result = MSqlCommand.ExecuteScalar();
                if (result == null)
                {
                  //  MSqlCommand.Transaction.Rollback();
                }
                else 
                {
                   // MSqlCommand.Transaction.Commit();
                }

                return result;

            }
            catch (Exception ex)
            {
                //throw new Exception(" no se pudo ejecutar la sentencia: \n" + MSqlCommand.CommandText + "\n error:" + ex.Message);
                throw new Exception(ex.Message + " query ejecutado " + MSqlCommand.CommandText);
            }
            finally
            {
                ManageConnection();
            }
        }






        private static void ManageParameters(List<SqlParameter> Pparameters)
        {

            if (Pparameters.Count > 0)
            {
                if(MSqlCommand.Parameters.Count > 0)
                    MSqlCommand.Parameters.Clear();
                    MSqlCommand.Parameters.AddRange(Pparameters.ToArray());
            }

        }






        #region Verificacion y creacion de ConnectionString
        public  static bool CheckAccess()
        {
            try
            {
                GetConexion();
                Conexion.Open();


                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                    Conexion.Close();
            }
        }






        public static void CrearAcceso(string pserver, string puser, string ppwd)
        {

            sqlConnBuilder.InitialCatalog = Constantes.BASE;
            sqlConnBuilder.DataSource = pserver;
            sqlConnBuilder.IntegratedSecurity = false;
            sqlConnBuilder.UserID = puser;
            sqlConnBuilder.Password = ppwd;
            bool check = false;
            

            try
            {   //grabo encriptado
                EncryptorMan.EncryptAndSave(sqlConnBuilder.ConnectionString );
                //seteo en la app
                Conexion.ConnectionString = sqlConnBuilder.ConnectionString;
            }
            catch (Exception ex2)
            {

                throw ex2;
            }
            try
            {
                //check = CheckAccess(sqlConnBuilder.ConnectionString);
                check = CheckAccess();

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        #endregion
    }

}
