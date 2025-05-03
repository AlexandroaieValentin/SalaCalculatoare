namespace InterfataUtilizator_WindowsForms
{
    partial class FormCautare
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtcautare = new MetroFramework.Controls.MetroTextBox();
            this.btncautare = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(202, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Introdu ID-ul calculatorului cautat";
            // 
            // txtcautare
            // 
            this.txtcautare.Location = new System.Drawing.Point(287, 98);
            this.txtcautare.Name = "txtcautare";
            this.txtcautare.Size = new System.Drawing.Size(91, 23);
            this.txtcautare.TabIndex = 1;
            // 
            // btncautare
            // 
            this.btncautare.Location = new System.Drawing.Point(504, 79);
            this.btncautare.Name = "btncautare";
            this.btncautare.Size = new System.Drawing.Size(144, 56);
            this.btncautare.TabIndex = 2;
            this.btncautare.Text = "Cauta";
            this.btncautare.Click += new System.EventHandler(this.btncautare_Click);
            // 
            // FormCautare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 416);
            this.Controls.Add(this.btncautare);
            this.Controls.Add(this.txtcautare);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormCautare";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Cautare Calculator Dupa I";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtcautare;
        private MetroFramework.Controls.MetroButton btncautare;
    }
}