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
            ConnectionStringsSection section = GetStringSection(configuration);
            string CONN = String.Empty;
            try
            {  bool checkeo = false;

                if ((!(section.ElementInformation.IsLocked)) && (!(section.SectionInformation.IsLocked)))
                {
                    if (section.SectionInformation.IsProtected) //encrypt is true so encrypt
                    {
                        // decrypt the file. 
                       section.SectionInformation.UnprotectSection();
                    }
                    //GetStringSection(configuration).ConnectionStrings.Add(new ConnectionStringSettings("nueva conexion", "CONNSTRINGNUEVA"));
                    //section.SectionInformation.ForceSave = true;
                    //configuration.Save();
                }
                //ConfigurationManager.RefreshSection("connectionStrings");


                if (section.ConnectionStrings.Count > 0)

                {
                    foreach (ConnectionStringSettings item in section.ConnectionStrings)
                    {
                        if (item.Name.Equals(Constantes.NOMBRECONEXION))
                        {
                            CONN = item.ConnectionString;
                            checkeo = true;
                        }
                    }
                }
                if (!checkeo)
                {
                    section.ConnectionStrings.Add(new ConnectionStringSettings(Constantes.NOMBRECONEXION, "conexiondefault"));
                    section.SectionInformation.ForceSave = true;

                    configuration.Save();
                   // Desencrypt();
                }
                    
                    return CONN;
               
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
        public static void EncryptAndSave(string pConnectionString)
        {
            try
            {

                Configuration configuration = GetConfiguration();
                ConnectionStringsSection  section = GetStringSection(configuration);
                bool checkeo = false;
                if (section.ConnectionStrings.Count > 0)

                    foreach (ConnectionStringSettings item in section.ConnectionStrings)
                    {
                        if (item.Name.Equals(Constantes.NOMBRECONEXION))
                        {
                            item.ConnectionString = pConnectionString;
                            checkeo = true;
                        }
                    }

                else if (!checkeo)
                {
                    section.ConnectionStrings.Add(new ConnectionStringSettings(Constantes.NOMBRECONEXION, pConnectionString)); section.SectionInformation.ForceSave = true;

                    configuration.Save();
                }


                if ((!(section.ElementInformation.IsLocked)) && (!(section.SectionInformation.IsLocked)))
                {
                    if ((!section.SectionInformation.IsProtected))
                    {
                        // encriptar el archivo
                       section.SectionInformation.ProtectSection(Constantes.PROTECTIONPROVIDER);
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

                    section.SectionInformation.ForceSave = true;
                    
                    configuration.Save();
                    //ConfigurationManager.GetSection("connectionStrings").
                    


                }

            }
            catch   (System.Configuration.ConfigurationException CONFEX)
            {
                throw new Exception("NO SE PUEDE DESENCRIPTAR LA CLAVE");
            }
            catch (Exception e2)
            {

                throw e2;
            }

        }


        #region Obtener Configuracion para el app.config
        private static ConnectionStringsSection GetStringSection(Configuration pconfig)
        {

           
            ConfigurationSection cfs = pconfig.GetSection(Constantes.CONNECTIONSTRING) as ConnectionStringsSection;
            if (cfs == null)
            { pconfig.Sections.Remove(Constantes.CONNECTIONSTRING);
                
                
            }
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
