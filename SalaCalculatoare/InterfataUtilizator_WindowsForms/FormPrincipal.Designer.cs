namespace InterfataUtilizator_WindowsForms
{
    partial class FormPrincipal
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
            this.btnadmin = new MetroFramework.Controls.MetroButton();
            this.btnutilizator = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(23, 177);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(358, 250);
            this.btnadmin.TabIndex = 0;
            this.btnadmin.Text = "Administrator";
            this.btnadmin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnadmin.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnutilizator
            // 
            this.btnutilizator.Location = new System.Drawing.Point(409, 177);
            this.btnutilizator.Name = "btnutilizator";
            this.btnutilizator.Size = new System.Drawing.Size(368, 252);
            this.btnutilizator.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnutilizator.TabIndex = 1;
            this.btnutilizator.Text = "Utilizator";
            this.btnutilizator.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.Black;
            this.metroTile1.Location = new System.Drawing.Point(-1, 25);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(802, 117);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Sala de Calculatoare";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnutilizator);
            this.Controls.Add(this.btnadmin);
            this.DisplayHeader = false;
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnadmin;
        private MetroFramework.Controls.MetroButton btnutilizator;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}