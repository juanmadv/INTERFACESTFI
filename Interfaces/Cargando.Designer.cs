
namespace Interfaces
{
    partial class Cargando
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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Backwards = true;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(192, 168);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(348, 162);
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Name = "Cargando";
            this.Text = "Cargando";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Cargando_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}