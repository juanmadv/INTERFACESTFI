using BE;
using Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        private ProxyAuth auth = new ProxyAuth();

        private async void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory()+ "//Interfaces.exe.config");
            //File.Delete(Directory.GetCurrentDirectory() + "//Interfaces.exe.config");

            try
            {
                File.Delete(Directory.GetCurrentDirectory() + "//Interfaces.exe.config");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL INTENTAR ELIMINAR EL ARCHIVO" + ex.Message);
            }
            


            //string IP2 = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            string host = Dns.GetHostName();//.AddressList[1].ToString();
            //var a = new System.Net.IPHostEntry();

            //Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
          //  MetroFramework.MetroMessageBox.Show(this, "IP Address is :\n" + IP, "IpObtenida", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // MetroFramework.MetroMessageBox.Show(this, "IP Address is :\n" + IP2, "IpObtenida", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            
            bool check = false;


            Console.WriteLine("INICIO ANTES DE TRY....");
            try
            {
            
                check =  ProxyAuth.InicioAsync();
              
            }
            catch (Exception e2)
            {
               

                MetroFramework.MetroMessageBox.Show(this, "No se puede conectar con la BD," + e2.Message + e2.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Console.WriteLine("DESPUES DE TRY....");

            if (!check)
            {
                //frm.Close();
            }

            if (check)
            {   //se deja para probar cambiar la conexion
                // Form formulario = new UIConexionBD();
                // formulario.ShowDialog();


                //logica login
            }
            else
            {

                //MetroFramework.Forms.MetroForm formulario = new UIConexionBD();
                //formulario.StyleManager = this.StyleMAIN;
                //formulario.ShowDialog ();
                //this.Close();
            }


        }

        


        private void metroBtnLogin_Click(object sender, EventArgs e)
        {
            Patente pat = null;

            try
            {
                 pat = auth.Login(new User(metroTxtEmail.Text, metroTxtPass.Text), metroTxtPass.Text, Dns.GetHostName());
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "", "ERROR", MessageBoxButtons.OK);
            }
            
            
            const string V = "Administracion";
           const int i = 0;
            if (pat != null)
            {
                switch (pat.Nombre)
                {
                    case "Administracion":
                        new UIAdministrador().Show();
                        break;
                    default:
                        break;
                }
            }
            //ADMIN

            if (1 == 1)
            {
                UIAdministrador fm = new UIAdministrador();
                
                fm.ShowDialog();
                
            }
        }

        private void metroCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            //if (metroCheckBox1.Checked)
            //    metroTxtPass.Enabled = false;
            //else
            //    metroTxtPass.Enabled = true;

        }
    }
}
