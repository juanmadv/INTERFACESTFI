
namespace Interfaces
{
    partial class UIConexionBD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Style = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metrotxtServer = new MetroFramework.Controls.MetroTextBox();
            this.metrotxtuser = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtPwd = new MetroFramework.Controls.MetroTextBox();
            this.metrobtnCrearConexion = new MetroFramework.Controls.MetroButton();
            this.metrobtnProbarConexion = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Style)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metrobtnProbarConexion);
            this.groupBox1.Controls.Add(this.metrobtnCrearConexion);
            this.groupBox1.Controls.Add(this.metrotxtServer);
            this.groupBox1.Controls.Add(this.metroTxtPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.metrotxtuser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 232);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexion Base de Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Style
            // 
            this.Style.Owner = this;
            // 
            // metrotxtServer
            // 
            // 
            // 
            // 
            this.metrotxtServer.CustomButton.Image = null;
            this.metrotxtServer.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.metrotxtServer.CustomButton.Name = "";
            this.metrotxtServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metrotxtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotxtServer.CustomButton.TabIndex = 1;
            this.metrotxtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotxtServer.CustomButton.UseSelectable = true;
            this.metrotxtServer.CustomButton.Visible = false;
            this.metrotxtServer.Lines = new string[] {
        "DESKTOP-4VCEOPG\\SQLEXPRESS"};
            this.metrotxtServer.Location = new System.Drawing.Point(104, 52);
            this.metrotxtServer.MaxLength = 32767;
            this.metrotxtServer.Name = "metrotxtServer";
            this.metrotxtServer.PasswordChar = '\0';
            this.metrotxtServer.PromptText = "Servidor";
            this.metrotxtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metrotxtServer.SelectedText = "";
            this.metrotxtServer.SelectionLength = 0;
            this.metrotxtServer.SelectionStart = 0;
            this.metrotxtServer.ShortcutsEnabled = true;
            this.metrotxtServer.Size = new System.Drawing.Size(231, 23);
            this.metrotxtServer.TabIndex = 9;
            this.metrotxtServer.Text = "DESKTOP-4VCEOPG\\SQLEXPRESS";
            this.metrotxtServer.UseSelectable = true;
            this.metrotxtServer.WaterMark = "Servidor";
            this.metrotxtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metrotxtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metrotxtuser
            // 
            // 
            // 
            // 
            this.metrotxtuser.CustomButton.Image = null;
            this.metrotxtuser.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.metrotxtuser.CustomButton.Name = "";
            this.metrotxtuser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metrotxtuser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotxtuser.CustomButton.TabIndex = 1;
            this.metrotxtuser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotxtuser.CustomButton.UseSelectable = true;
            this.metrotxtuser.CustomButton.Visible = false;
            this.metrotxtuser.Lines = new string[] {
        "VsUser"};
            this.metrotxtuser.Location = new System.Drawing.Point(104, 94);
            this.metrotxtuser.MaxLength = 32767;
            this.metrotxtuser.Name = "metrotxtuser";
            this.metrotxtuser.PasswordChar = '\0';
            this.metrotxtuser.PromptText = "Servidor";
            this.metrotxtuser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metrotxtuser.SelectedText = "";
            this.metrotxtuser.SelectionLength = 0;
            this.metrotxtuser.SelectionStart = 0;
            this.metrotxtuser.ShortcutsEnabled = true;
            this.metrotxtuser.Size = new System.Drawing.Size(140, 23);
            this.metrotxtuser.TabIndex = 10;
            this.metrotxtuser.Text = "VsUser";
            this.metrotxtuser.UseSelectable = true;
            this.metrotxtuser.WaterMark = "Servidor";
            this.metrotxtuser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metrotxtuser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTxtPwd
            // 
            // 
            // 
            // 
            this.metroTxtPwd.CustomButton.Image = null;
            this.metroTxtPwd.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.metroTxtPwd.CustomButton.Name = "";
            this.metroTxtPwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtPwd.CustomButton.TabIndex = 1;
            this.metroTxtPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtPwd.CustomButton.UseSelectable = true;
            this.metroTxtPwd.CustomButton.Visible = false;
            this.metroTxtPwd.Lines = new string[] {
        "VsUser1"};
            this.metroTxtPwd.Location = new System.Drawing.Point(329, 94);
            this.metroTxtPwd.MaxLength = 32767;
            this.metroTxtPwd.Name = "metroTxtPwd";
            this.metroTxtPwd.PasswordChar = '\0';
            this.metroTxtPwd.PromptText = "Servidor";
            this.metroTxtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtPwd.SelectedText = "";
            this.metroTxtPwd.SelectionLength = 0;
            this.metroTxtPwd.SelectionStart = 0;
            this.metroTxtPwd.ShortcutsEnabled = true;
            this.metroTxtPwd.Size = new System.Drawing.Size(100, 23);
            this.metroTxtPwd.TabIndex = 11;
            this.metroTxtPwd.Text = "VsUser1";
            this.metroTxtPwd.UseSelectable = true;
            this.metroTxtPwd.WaterMark = "Servidor";
            this.metroTxtPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metrobtnCrearConexion
            // 
            this.metrobtnCrearConexion.Location = new System.Drawing.Point(90, 162);
            this.metrobtnCrearConexion.Name = "metrobtnCrearConexion";
            this.metrobtnCrearConexion.Size = new System.Drawing.Size(154, 23);
            this.metrobtnCrearConexion.TabIndex = 9;
            this.metrobtnCrearConexion.Text = "Crear Conexión";
            this.metrobtnCrearConexion.UseSelectable = true;
            this.metrobtnCrearConexion.Click += new System.EventHandler(this.metrobtnCrearConexion_Click);
            // 
            // metrobtnProbarConexion
            // 
            this.metrobtnProbarConexion.Location = new System.Drawing.Point(275, 162);
            this.metrobtnProbarConexion.Name = "metrobtnProbarConexion";
            this.metrobtnProbarConexion.Size = new System.Drawing.Size(154, 23);
            this.metrobtnProbarConexion.TabIndex = 10;
            this.metrobtnProbarConexion.Text = "Probar Conexión";
            this.metrobtnProbarConexion.UseSelectable = true;
            this.metrobtnProbarConexion.Click += new System.EventHandler(this.metrobtnProbarConexion_Click);
            // 
            // UIConexionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 378);
            this.Controls.Add(this.groupBox1);
            this.Name = "UIConexionBD";
            this.Text = "UIConexionBD";
            this.TransparencyKey = System.Drawing.Color.CornflowerBlue;
            this.Load += new System.EventHandler(this.UIConexionBD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Style)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Components.MetroStyleManager Style;
        private MetroFramework.Controls.MetroTextBox metrotxtServer;
        private MetroFramework.Controls.MetroTextBox metroTxtPwd;
        private MetroFramework.Controls.MetroTextBox metrotxtuser;
        private MetroFramework.Controls.MetroButton metrobtnProbarConexion;
        private MetroFramework.Controls.MetroButton metrobtnCrearConexion;
    }
}