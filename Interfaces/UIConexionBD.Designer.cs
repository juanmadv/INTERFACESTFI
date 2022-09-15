
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
            this.StyleBD = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.PageConexion = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtServer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metrotxtuser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTxtPwd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.ServerSelection = new MetroFramework.Controls.MetroComboBox();
            this.PageBackUp = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnBackUp = new MetroFramework.Controls.MetroButton();
            this.TxtBkUp2 = new MetroFramework.Controls.MetroTextBox();
            this.TxtBkUp1 = new MetroFramework.Controls.MetroTextBox();
            this.PageRestore = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnRestore = new MetroFramework.Controls.MetroButton();
            this.TxtRestore2 = new MetroFramework.Controls.MetroTextBox();
            this.TxtRestore1 = new MetroFramework.Controls.MetroTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.StyleBD)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.PageConexion.SuspendLayout();
            this.PageBackUp.SuspendLayout();
            this.PageRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleBD
            // 
            this.StyleBD.Owner = this;
            this.StyleBD.Style = global::Interfaces.Properties.Settings.Default.StyleJuanma;
            this.StyleBD.Theme = global::Interfaces.Properties.Settings.Default.ThemeJuanma;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.PageConexion);
            this.metroTabControl1.Controls.Add(this.PageBackUp);
            this.metroTabControl1.Controls.Add(this.PageRestore);
            this.metroTabControl1.Location = new System.Drawing.Point(36, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(406, 396);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 16;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // PageConexion
            // 
            this.PageConexion.Controls.Add(this.metroButton2);
            this.PageConexion.Controls.Add(this.txtServer);
            this.PageConexion.Controls.Add(this.metroLabel6);
            this.PageConexion.Controls.Add(this.metrotxtuser);
            this.PageConexion.Controls.Add(this.metroLabel7);
            this.PageConexion.Controls.Add(this.metroTxtPwd);
            this.PageConexion.Controls.Add(this.metroLabel8);
            this.PageConexion.Controls.Add(this.ServerSelection);
            this.PageConexion.HorizontalScrollbarBarColor = true;
            this.PageConexion.HorizontalScrollbarHighlightOnWheel = false;
            this.PageConexion.HorizontalScrollbarSize = 10;
            this.PageConexion.Location = new System.Drawing.Point(4, 38);
            this.PageConexion.Name = "PageConexion";
            this.PageConexion.Size = new System.Drawing.Size(398, 354);
            this.PageConexion.TabIndex = 0;
            this.PageConexion.Text = "Conexion BD";
            this.PageConexion.VerticalScrollbarBarColor = true;
            this.PageConexion.VerticalScrollbarHighlightOnWheel = false;
            this.PageConexion.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(94, 257);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(187, 23);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Crear Conexión";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metrobtnCrearConexion_Click);
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.CustomButton.Image = null;
            this.txtServer.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtServer.CustomButton.Name = "";
            this.txtServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServer.CustomButton.TabIndex = 1;
            this.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServer.CustomButton.UseSelectable = true;
            this.txtServer.CustomButton.Visible = false;
            this.txtServer.Lines = new string[0];
            this.txtServer.Location = new System.Drawing.Point(94, 94);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.PromptText = "Servidor";
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.ShortcutsEnabled = true;
            this.txtServer.Size = new System.Drawing.Size(187, 23);
            this.txtServer.TabIndex = 9;
            this.txtServer.UseSelectable = true;
            this.txtServer.WaterMark = "Servidor";
            this.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 184);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Password";
            // 
            // metrotxtuser
            // 
            // 
            // 
            // 
            this.metrotxtuser.CustomButton.Image = null;
            this.metrotxtuser.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.metrotxtuser.CustomButton.Name = "";
            this.metrotxtuser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metrotxtuser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotxtuser.CustomButton.TabIndex = 1;
            this.metrotxtuser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotxtuser.CustomButton.UseSelectable = true;
            this.metrotxtuser.CustomButton.Visible = false;
            this.metrotxtuser.Lines = new string[] {
        "VsUser"};
            this.metrotxtuser.Location = new System.Drawing.Point(94, 140);
            this.metrotxtuser.MaxLength = 32767;
            this.metrotxtuser.Name = "metrotxtuser";
            this.metrotxtuser.PasswordChar = '\0';
            this.metrotxtuser.PromptText = "User BD";
            this.metrotxtuser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metrotxtuser.SelectedText = "";
            this.metrotxtuser.SelectionLength = 0;
            this.metrotxtuser.SelectionStart = 0;
            this.metrotxtuser.ShortcutsEnabled = true;
            this.metrotxtuser.Size = new System.Drawing.Size(187, 23);
            this.metrotxtuser.TabIndex = 10;
            this.metrotxtuser.Text = "VsUser";
            this.metrotxtuser.UseSelectable = true;
            this.metrotxtuser.WaterMark = "User BD";
            this.metrotxtuser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metrotxtuser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 144);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "User";
            // 
            // metroTxtPwd
            // 
            // 
            // 
            // 
            this.metroTxtPwd.CustomButton.Image = null;
            this.metroTxtPwd.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.metroTxtPwd.CustomButton.Name = "";
            this.metroTxtPwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtPwd.CustomButton.TabIndex = 1;
            this.metroTxtPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtPwd.CustomButton.UseSelectable = true;
            this.metroTxtPwd.CustomButton.Visible = false;
            this.metroTxtPwd.Lines = new string[] {
        "VsUser1"};
            this.metroTxtPwd.Location = new System.Drawing.Point(94, 184);
            this.metroTxtPwd.MaxLength = 32767;
            this.metroTxtPwd.Name = "metroTxtPwd";
            this.metroTxtPwd.PasswordChar = '*';
            this.metroTxtPwd.PromptText = "Servidor";
            this.metroTxtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtPwd.SelectedText = "";
            this.metroTxtPwd.SelectionLength = 0;
            this.metroTxtPwd.SelectionStart = 0;
            this.metroTxtPwd.ShortcutsEnabled = true;
            this.metroTxtPwd.Size = new System.Drawing.Size(187, 23);
            this.metroTxtPwd.TabIndex = 11;
            this.metroTxtPwd.Text = "VsUser1";
            this.metroTxtPwd.UseSelectable = true;
            this.metroTxtPwd.WaterMark = "Servidor";
            this.metroTxtPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 98);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(47, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Server";
            // 
            // ServerSelection
            // 
            this.ServerSelection.FormattingEnabled = true;
            this.ServerSelection.ItemHeight = 23;
            this.ServerSelection.Items.AddRange(new object[] {
            "DESKTOP-4VCEOPG\\SQLEXPRESS"});
            this.ServerSelection.Location = new System.Drawing.Point(94, 47);
            this.ServerSelection.Name = "ServerSelection";
            this.ServerSelection.Size = new System.Drawing.Size(187, 29);
            this.ServerSelection.TabIndex = 12;
            this.ServerSelection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ServerSelection.UseSelectable = true;
            this.ServerSelection.SelectedIndexChanged += new System.EventHandler(this.ServerSelection_SelectedIndexChanged);
            // 
            // PageBackUp
            // 
            this.PageBackUp.Controls.Add(this.metroLabel9);
            this.PageBackUp.Controls.Add(this.metroLabel10);
            this.PageBackUp.Controls.Add(this.btnBackUp);
            this.PageBackUp.Controls.Add(this.TxtBkUp2);
            this.PageBackUp.Controls.Add(this.TxtBkUp1);
            this.PageBackUp.HorizontalScrollbarBarColor = true;
            this.PageBackUp.HorizontalScrollbarHighlightOnWheel = false;
            this.PageBackUp.HorizontalScrollbarSize = 10;
            this.PageBackUp.Location = new System.Drawing.Point(4, 38);
            this.PageBackUp.Name = "PageBackUp";
            this.PageBackUp.Size = new System.Drawing.Size(398, 354);
            this.PageBackUp.TabIndex = 1;
            this.PageBackUp.Text = "BackUp";
            this.PageBackUp.VerticalScrollbarBarColor = true;
            this.PageBackUp.VerticalScrollbarHighlightOnWheel = false;
            this.PageBackUp.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 118);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(113, 19);
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "Directorio Parte 2";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(13, 62);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(111, 19);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Text = "Directorio Parte 1";
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(130, 161);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(213, 23);
            this.btnBackUp.TabIndex = 4;
            this.btnBackUp.Text = "Crear BackUp";
            this.btnBackUp.UseSelectable = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // TxtBkUp2
            // 
            // 
            // 
            // 
            this.TxtBkUp2.CustomButton.Image = null;
            this.TxtBkUp2.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.TxtBkUp2.CustomButton.Name = "";
            this.TxtBkUp2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBkUp2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBkUp2.CustomButton.TabIndex = 1;
            this.TxtBkUp2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBkUp2.CustomButton.UseSelectable = true;
            this.TxtBkUp2.CustomButton.Visible = false;
            this.TxtBkUp2.Lines = new string[0];
            this.TxtBkUp2.Location = new System.Drawing.Point(130, 114);
            this.TxtBkUp2.MaxLength = 32767;
            this.TxtBkUp2.Name = "TxtBkUp2";
            this.TxtBkUp2.PasswordChar = '\0';
            this.TxtBkUp2.PromptText = "C:\\\\BackUp2\\";
            this.TxtBkUp2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBkUp2.SelectedText = "";
            this.TxtBkUp2.SelectionLength = 0;
            this.TxtBkUp2.SelectionStart = 0;
            this.TxtBkUp2.ShortcutsEnabled = true;
            this.TxtBkUp2.Size = new System.Drawing.Size(213, 23);
            this.TxtBkUp2.TabIndex = 3;
            this.TxtBkUp2.UseSelectable = true;
            this.TxtBkUp2.WaterMark = "C:\\\\BackUp2\\";
            this.TxtBkUp2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBkUp2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtBkUp1
            // 
            // 
            // 
            // 
            this.TxtBkUp1.CustomButton.Image = null;
            this.TxtBkUp1.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.TxtBkUp1.CustomButton.Name = "";
            this.TxtBkUp1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBkUp1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBkUp1.CustomButton.TabIndex = 1;
            this.TxtBkUp1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBkUp1.CustomButton.UseSelectable = true;
            this.TxtBkUp1.CustomButton.Visible = false;
            this.TxtBkUp1.Lines = new string[0];
            this.TxtBkUp1.Location = new System.Drawing.Point(130, 62);
            this.TxtBkUp1.MaxLength = 32767;
            this.TxtBkUp1.Name = "TxtBkUp1";
            this.TxtBkUp1.PasswordChar = '\0';
            this.TxtBkUp1.PromptText = "C:\\\\BackUp1\\";
            this.TxtBkUp1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBkUp1.SelectedText = "";
            this.TxtBkUp1.SelectionLength = 0;
            this.TxtBkUp1.SelectionStart = 0;
            this.TxtBkUp1.ShortcutsEnabled = true;
            this.TxtBkUp1.Size = new System.Drawing.Size(213, 23);
            this.TxtBkUp1.TabIndex = 2;
            this.TxtBkUp1.UseSelectable = true;
            this.TxtBkUp1.WaterMark = "C:\\\\BackUp1\\";
            this.TxtBkUp1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBkUp1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PageRestore
            // 
            this.PageRestore.Controls.Add(this.metroTile1);
            this.PageRestore.Controls.Add(this.metroLabel1);
            this.PageRestore.Controls.Add(this.metroLabel2);
            this.PageRestore.Controls.Add(this.BtnRestore);
            this.PageRestore.Controls.Add(this.TxtRestore2);
            this.PageRestore.Controls.Add(this.TxtRestore1);
            this.PageRestore.HorizontalScrollbarBarColor = true;
            this.PageRestore.HorizontalScrollbarHighlightOnWheel = false;
            this.PageRestore.HorizontalScrollbarSize = 10;
            this.PageRestore.Location = new System.Drawing.Point(4, 38);
            this.PageRestore.Name = "PageRestore";
            this.PageRestore.Size = new System.Drawing.Size(398, 354);
            this.PageRestore.TabIndex = 2;
            this.PageRestore.Text = "Restore";
            this.PageRestore.VerticalScrollbarBarColor = true;
            this.PageRestore.VerticalScrollbarHighlightOnWheel = false;
            this.PageRestore.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(130, 212);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(213, 23);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "Selecionar";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Directorio Parte 2";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Directorio Parte 1";
            // 
            // BtnRestore
            // 
            this.BtnRestore.Location = new System.Drawing.Point(130, 161);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(213, 23);
            this.BtnRestore.TabIndex = 9;
            this.BtnRestore.Text = "Restore";
            this.BtnRestore.UseSelectable = true;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // TxtRestore2
            // 
            // 
            // 
            // 
            this.TxtRestore2.CustomButton.Image = null;
            this.TxtRestore2.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.TxtRestore2.CustomButton.Name = "";
            this.TxtRestore2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRestore2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRestore2.CustomButton.TabIndex = 1;
            this.TxtRestore2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRestore2.CustomButton.UseSelectable = true;
            this.TxtRestore2.CustomButton.Visible = false;
            this.TxtRestore2.Lines = new string[0];
            this.TxtRestore2.Location = new System.Drawing.Point(130, 114);
            this.TxtRestore2.MaxLength = 32767;
            this.TxtRestore2.Name = "TxtRestore2";
            this.TxtRestore2.PasswordChar = '\0';
            this.TxtRestore2.PromptText = "C:\\\\BackUp2\\";
            this.TxtRestore2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRestore2.SelectedText = "";
            this.TxtRestore2.SelectionLength = 0;
            this.TxtRestore2.SelectionStart = 0;
            this.TxtRestore2.ShortcutsEnabled = true;
            this.TxtRestore2.Size = new System.Drawing.Size(213, 23);
            this.TxtRestore2.TabIndex = 8;
            this.TxtRestore2.UseSelectable = true;
            this.TxtRestore2.WaterMark = "C:\\\\BackUp2\\";
            this.TxtRestore2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRestore2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtRestore1
            // 
            // 
            // 
            // 
            this.TxtRestore1.CustomButton.Image = null;
            this.TxtRestore1.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.TxtRestore1.CustomButton.Name = "";
            this.TxtRestore1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRestore1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRestore1.CustomButton.TabIndex = 1;
            this.TxtRestore1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRestore1.CustomButton.UseSelectable = true;
            this.TxtRestore1.CustomButton.Visible = false;
            this.TxtRestore1.Lines = new string[0];
            this.TxtRestore1.Location = new System.Drawing.Point(130, 62);
            this.TxtRestore1.MaxLength = 32767;
            this.TxtRestore1.Name = "TxtRestore1";
            this.TxtRestore1.PasswordChar = '\0';
            this.TxtRestore1.PromptText = "C:\\\\BackUp1\\";
            this.TxtRestore1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRestore1.SelectedText = "";
            this.TxtRestore1.SelectionLength = 0;
            this.TxtRestore1.SelectionStart = 0;
            this.TxtRestore1.ShortcutsEnabled = true;
            this.TxtRestore1.Size = new System.Drawing.Size(213, 23);
            this.TxtRestore1.TabIndex = 7;
            this.TxtRestore1.UseSelectable = true;
            this.TxtRestore1.WaterMark = "C:\\\\BackUp1\\";
            this.TxtRestore1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRestore1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UIConexionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 493);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UIConexionBD";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Administración";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.PowderBlue;
            this.Load += new System.EventHandler(this.UIConexionBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StyleBD)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.PageConexion.ResumeLayout(false);
            this.PageConexion.PerformLayout();
            this.PageBackUp.ResumeLayout(false);
            this.PageBackUp.PerformLayout();
            this.PageRestore.ResumeLayout(false);
            this.PageRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleBD;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage PageConexion;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txtServer;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metrotxtuser;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTxtPwd;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox ServerSelection;
        private MetroFramework.Controls.MetroTabPage PageBackUp;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnBackUp;
        private MetroFramework.Controls.MetroTextBox TxtBkUp2;
        private MetroFramework.Controls.MetroTextBox TxtBkUp1;
        private MetroFramework.Controls.MetroTabPage PageRestore;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnRestore;
        private MetroFramework.Controls.MetroTextBox TxtRestore2;
        private MetroFramework.Controls.MetroTextBox TxtRestore1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}