using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Security;
namespace Interfaces
{
    public partial class UIConexionBD : MetroFramework.Forms.MetroForm
    {
        public UIConexionBD()
        {
            
            InitializeComponent();
            this.StyleManager = Style;
            
        }

        private ProxyAuth auth = new ProxyAuth();

        private void btnCrearConexion_Click(object sender, EventArgs e)
        {
            try
            {
                auth.inicio(metrotxtServer.Text, metrotxtuser.Text, metroTxtPwd.Text);
                MessageBox.Show("Para restablecer la conexión se reiniciara la app...." ,"Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Owner.Close();
                Application.Restart();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + MessageBoxIcon.Error + ex.Message + ex.StackTrace );
               
            }
            

        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            
            
        }

        private void UIConexionBD_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metrobtnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                string check = auth.inicio();
                MessageBox.Show("Conexion exitosa");
                MetroFramework.MetroMessageBox.Show(null, "conexion exitosa");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(null,"hay un error en la conexion de la base de datos, por favor cree una nueva conexion" + ex.Message);

                               
            }
        }

        private void metrobtnCrearConexion_Click(object sender, EventArgs e)
        {
            try
            {
                auth.inicio(metrotxtServer.Text, metrotxtuser.Text, metroTxtPwd.Text);
                MetroFramework.MetroMessageBox.Show(this.Owner,"Para restablecer la conexión se reiniciara la app....", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Owner.Dispose();

                Application.Restart();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.Owner, "ERROR: " + MessageBoxIcon.Error + ex.Message + ex.StackTrace);

               //MessageBox.Show("ERROR " + MessageBoxIcon.Error + ex.Message + ex.StackTrace);

            }

        }
    }
}
