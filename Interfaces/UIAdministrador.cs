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
using System.Configuration;
using BE.Constantes;
using DAL;
using BE;
using System.Reflection;
using Util;

namespace Interfaces
{
    public partial class UIAdministrador : MetroFramework.Forms.MetroForm
    {
        public UIAdministrador()
        {
            
            InitializeComponent();
            
           
            
        }

        private List<Bitacora> mbitacora = new List<Bitacora>();

        private ProxyAuth auth = new ProxyAuth();

        private void btnCrearConexion_Click(object sender, EventArgs e)
        {
            try
            {
                auth.IniciarBase(txtServer.Text, metrotxtuser.Text, metroTxtPwd.Text);
                MessageBox.Show("Para restablecer la conexión se reiniciara la app...." ,"Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Owner.Close();
                //Application.Restart();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + MessageBoxIcon.Error + ex.Message + ex.StackTrace );
               
            }
            

        }



        private void UIConexionBD_Load(object sender, EventArgs e)
        {

            InitGrd();



        }

        private void MetroTab_Selected(object sender, TabControlEventArgs e)
        {
            this.Text = "NUEVO";
        }

  



        private void metrobtnCrearConexion_Click(object sender, EventArgs e)
        {

            #region PRUEBA ORDENAMIENTO DE LISTAS
            //Bitacora bit1 = new Bitacora("abc",1,"abc", DateTime.Now);
            //Bitacora bit2 = new Bitacora("acb", 2, "def", DateTime.Now.AddHours(-1));
            //Bitacora bit3 = new Bitacora("asdfasf", 2, "ghi", DateTime.Now.AddHours(-1));
            //BitacoraMapper bm= new BitacoraMapper();

            //List<Bitacora> MLISTA = new List<Bitacora>();
            //MLISTA.Add(bit1);
            //MLISTA.Add(bit3);
            //MLISTA.Add(bit2);

            //MLISTA.ForEach(Z => Console.WriteLine($"Lista desordenada\n DESCRIPCION: {Z.Descripcion} {Z.Fecha} "));

            //List<Bitacora> sorted =  MLISTA.OrderBy(z => z.Fecha).ThenBy(z=> z.Descripcion).ToList();

            //sorted.ForEach(Z => Console.WriteLine($"Lista Ordenada\n DESCRIPCION: {Z.Descripcion} {Z.Fecha} "));


            #endregion


                try
            {
                auth.IniciarBase(txtServer.Text, metrotxtuser.Text, metroTxtPwd.Text);
                MetroFramework.MetroMessageBox.Show(this, "Conexión creada con éxito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                
                MetroFramework.MetroMessageBox.Show(this, "ERROR: " , ex.Message + ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);                

            }

        }


        private void ActualizarTabBACKUP(object sender, TabControlEventArgs evargs)
        {

            if (evargs.Action == TabControlAction.Selected)
            {                
                switch (evargs.TabPage.Name)
                {
                    case "TabRestore":
                        MessageBox.Show("llame a RESTORE");
                        break;
                    case "TabConexionBd":
                        MessageBox.Show("LLame a CONEXION");
                        break;
                    case "TabBackUp":
                        MessageBox.Show("LLame a BKUP ");
                        break;

                    default:
                        break;
                }


            }
        }






        private void btnBackUp_Click(object sender, EventArgs e)
        {

        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            
           
            string ruta2 = folderBrowserDialog1.SelectedPath + "\\3.bk";
            string ruta3 = folderBrowserDialog1.SelectedPath + "\\4.bk";


          
            //System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(ruta);
            //streamWriter.Write(true);
            //streamWriter.Flush();
            //streamWriter.Close();
            try
            {
                auth.StartBkUp(ruta2, ruta3);
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this,"ERROR  " + ex.Message + ex.StackTrace);
            }
            

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog1.ShowDialog();
            TxtRestore1.Text = folderBrowserDialog1.SelectedPath +"\\"+Guid.NewGuid().ToString() + "_V1";
            TxtRestore2.Text = folderBrowserDialog1.SelectedPath + DateTime.Today.ToString() + "_V2";
  
            MessageBox.Show("Selecciono + " + folderBrowserDialog1.SelectedPath);
        }

        private void ServerSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServer.Text = this.ServerSelection.Text;
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnOrdFecha_Click(object sender, EventArgs e)
        {
            List<Bitacora> sorted = mbitacora.OrderBy(z => z.Fecha).ThenBy(z => z.Descripcion).ToList();
            this.grd.DataSource = null;
            this.grd.DataSource = sorted;
        }


        private void InitGrd()
        {
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd.EditMode = DataGridViewEditMode.EditProgrammatically;
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd.AutoGenerateColumns = false;

            grd.Columns.Add("Descripcion", "Descripcion");
            grd.Columns[0].DataPropertyName = "Descripcion";
            grd.Columns.Add("Criticidad", "Criticidad");
            grd.Columns[1].DataPropertyName = "Criticidad";
            grd.Columns.Add("Fecha", "Fecha");
            grd.Columns[2].DataPropertyName = "Fecha";
            grd.Columns.Add("Host", "Host");
            grd.Columns[3].DataPropertyName = "Host";            

        }

        private void btnOrdenCriticidad_Click(object sender, EventArgs e)
        {
            List<Bitacora> sorted = mbitacora.OrderBy(z => z.Criticidad).ToList();
            this.grd.DataSource = null;
            this.grd.DataSource = sorted;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<Bitacora> sorted = mbitacora.Where(X => X.Fecha >= Mdate.Value).ToList();
            this.grd.DataSource = null;
            this.grd.DataSource = sorted;

        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                mbitacora = auth.ListarBitacora();

                this.grd.DataSource = null;
                this.grd.DataSource = mbitacora;
                grd.Show();
                /// List < Bitacora > sorted = MLISTA.OrderBy(z => z.Fecha).ThenBy(z => z.Descripcion).ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
