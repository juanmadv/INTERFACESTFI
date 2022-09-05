using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Constantes;

namespace DAL
{
     public class EncryptorMan
    {


        #region configuracion por singleton (depurar)
        private static Configuration _configuration;

        private static Configuration GetConfig()
        {
            return _configuration == null ? ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None) : _configuration;            
        }
        #endregion


        public static string Desencrypt()
        {
            Configuration configuration = GetConfiguration();

            try
            {

                if ((!(GetStringSection(configuration).ElementInformation.IsLocked)) && (!(GetStringSection(configuration).SectionInformation.IsLocked)))
                {
                    if (GetStringSection(configuration).SectionInformation.IsProtected) //encrypt is true so encrypt
                    {
                        // decrypt the file. 
                        GetStringSection(configuration).SectionInformation.UnprotectSection();
                    }
                    //GetStringSection(configuration).ConnectionStrings.Add(new ConnectionStringSettings("nueva conexion", "CONNSTRINGNUEVA"));
                    //GetStringSection(configuration).SectionInformation.ForceSave = true;
                    //configuration.Save();
                }


                return GetStringSection(configuration).ConnectionStrings[2].ConnectionString;
            }

            catch (Exception e2)
            {

                throw e2;
            }
            
             
        }



        /// <summary>
        /// fuente: https://docs.microsoft.com/en-us/dotnet/api/system.configuration.sectioninformation.protectsection?view=dotnet-plat-ext-6.0
        /// https://docs.microsoft.com/en-us/answers/questions/273839/how-to-encrypt-connection-string-in-appconfig.html
        /// </summary>
        public static void EncryptAndSave(string pConectionString)
        {
            try
            {

                Configuration configuration = GetConfiguration();


                if ((!(GetStringSection(configuration).ElementInformation.IsLocked)) && (!(GetStringSection(configuration).SectionInformation.IsLocked)))
                {
                    if ((!GetStringSection(configuration).SectionInformation.IsProtected))
                    {
                        // encriptar el archivo
                        GetStringSection(configuration).SectionInformation.ProtectSection(Constantes.PROTECTIONPROVIDER);
                    }
                    #region verificar si graba ok 
                    /* se prueba para ver si grabo ok */
                    /*if (GetStringSection(configuration).SectionInformation.IsProtected) //encrypt is true so encrypt
                    {
                        // decrypt the file. 
                        GetStringSection(configuration).SectionInformation.UnprotectSection();
                    }
                    */
                    /* FIN se prueba para ver si grabo ok */
                    #endregion

                    GetStringSection(configuration).ConnectionStrings.RemoveAt(2);
                    //el comando clear agrega </clear> en el .config hace fallar la aplicacion.
                    //GetStringSection(configuration).ConnectionStrings.Clear();
                    GetStringSection(configuration).ConnectionStrings.Add(new ConnectionStringSettings(Constantes.NOMBRECONEXION, pConectionString));
                    GetStringSection(configuration).SectionInformation.ForceSave = true;

                    //ConfigurationManager.RefreshSection(Constantes.CONNECTIONSTRING);
                    configuration.Save();

                    //ConfigurationManager.RefreshSection(Constantes.CONNECTIONSTRING);
                    //GetConfiguration().GetSection(Constantes.CONNECTIONSTRING).ToString());
                    
                    

                }

            }
            catch (Exception e2)
            {

                throw e2;
            }

        }


        #region Obtener Configuracion para el app.config
        private static ConnectionStringsSection GetStringSection(Configuration pconfig)
        {

            return pconfig.GetSection(Constantes.CONNECTIONSTRING) as ConnectionStringsSection;
        }


        private static Configuration GetConfiguration()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            return configuration;
        }

        #endregion

    }
}
