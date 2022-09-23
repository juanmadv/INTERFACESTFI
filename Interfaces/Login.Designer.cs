
namespace Interfaces
{
    partial class Login
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
            this.metroTxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroBtnLogin = new MetroFramework.Controls.MetroButton();
            this.StyleMAIN = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMAIN)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTxtEmail
            // 
            // 
            // 
            // 
            this.metroTxtEmail.CustomButton.Image = null;
            this.metroTxtEmail.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.metroTxtEmail.CustomButton.Name = "";
            this.metroTxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtEmail.CustomButton.TabIndex = 1;
            this.metroTxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtEmail.CustomButton.UseSelectable = true;
            this.metroTxtEmail.CustomButton.Visible = false;
            this.metroTxtEmail.Lines = new string[0];
            this.metroTxtEmail.Location = new System.Drawing.Point(101, 90);
            this.metroTxtEmail.MaxLength = 32767;
            this.metroTxtEmail.Name = "metroTxtEmail";
            this.metroTxtEmail.PasswordChar = '\0';
            this.metroTxtEmail.PromptText = "Email";
            this.metroTxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtEmail.SelectedText = "";
            this.metroTxtEmail.SelectionLength = 0;
            this.metroTxtEmail.SelectionStart = 0;
            this.metroTxtEmail.ShortcutsEnabled = true;
            this.metroTxtEmail.Size = new System.Drawing.Size(187, 23);
            this.metroTxtEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtEmail.TabIndex = 0;
            this.metroTxtEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTxtEmail.UseSelectable = true;
            this.metroTxtEmail.UseStyleColors = true;
            this.metroTxtEmail.WaterMark = "Email";
            this.metroTxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTxtPass
            // 
            // 
            // 
            // 
            this.metroTxtPass.CustomButton.Image = null;
            this.metroTxtPass.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.metroTxtPass.CustomButton.Name = "";
            this.metroTxtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtPass.CustomButton.TabIndex = 1;
            this.metroTxtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtPass.CustomButton.UseSelectable = true;
            this.metroTxtPass.CustomButton.Visible = false;
            this.metroTxtPass.Lines = new string[0];
            this.metroTxtPass.Location = new System.Drawing.Point(101, 131);
            this.metroTxtPass.MaxLength = 32767;
            this.metroTxtPass.Name = "metroTxtPass";
            this.metroTxtPass.PasswordChar = '*';
            this.metroTxtPass.PromptText = "Password";
            this.metroTxtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtPass.SelectedText = "";
            this.metroTxtPass.SelectionLength = 0;
            this.metroTxtPass.SelectionStart = 0;
            this.metroTxtPass.ShortcutsEnabled = true;
            this.metroTxtPass.Size = new System.Drawing.Size(187, 23);
            this.metroTxtPass.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtPass.TabIndex = 1;
            this.metroTxtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTxtPass.UseSelectable = true;
            this.metroTxtPass.UseStyleColors = true;
            this.metroTxtPass.WaterMark = "Password";
            this.metroTxtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroBtnLogin
            // 
            this.metroBtnLogin.Location = new System.Drawing.Point(101, 219);
            this.metroBtnLogin.Name = "metroBtnLogin";
            this.metroBtnLogin.Size = new System.Drawing.Size(187, 23);
            this.metroBtnLogin.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroBtnLogin.TabIndex = 2;
            this.metroBtnLogin.Text = "Login";
            this.metroBtnLogin.UseSelectable = true;
            this.metroBtnLogin.UseStyleColors = true;
            this.metroBtnLogin.Click += new System.EventHandler(this.metroBtnLogin_Click);
            // 
            // StyleMAIN
            // 
            this.StyleMAIN.Owner = this;
            this.StyleMAIN.Style = MetroFramework.MetroColorStyle.Silver;
            this.StyleMAIN.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroToggle1.Location = new System.Drawing.Point(208, 173);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 3;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggle1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(101, 175);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Recuperar Pass";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.WrapToLine = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 304);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.metroBtnLogin);
            this.Controls.Add(this.metroTxtPass);
            this.Controls.Add(this.metroTxtEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMAIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTxtEmail;
        private MetroFramework.Controls.MetroTextBox metroTxtPass;
        private MetroFramework.Controls.MetroButton metroBtnLogin;
        private MetroFramework.Components.MetroStyleManager StyleMAIN;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}