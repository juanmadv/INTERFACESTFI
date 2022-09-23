using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            // Application.Run(new UIConexionBD());
            try
            {
                Application.Run(new Login());
            }
            catch (Exception ex)
            {
                File.Delete(Directory.GetCurrentDirectory() + "//Interfaces.exe.config");
                MessageBox.Show("ERROR AL INTENTAR INICIARLIZAR LA APLICACION. Reiniciando..." + ex.Message);
                Application.Run(new Login());

            }
        }
    }
}
