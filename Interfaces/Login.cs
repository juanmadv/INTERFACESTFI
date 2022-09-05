using Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string check = null;
            ProxyAuth auth = new ProxyAuth();
            try
            {
                 check = auth.inicio();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"No se puede conectar con la base de datos, por favor actualice la conexion a continuacion...");                            
            }
            
            
            if (check != null)
            {
                //logica login
            }
            else
            {

                Form formulario = new UIConexionBD();
                formulario.ShowDialog ();
            }


        
        }
    }
}
