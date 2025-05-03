using System;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    partial class adminform
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btninapoi = new MetroFramework.Controls.MetroButton();
            this.btncautare = new MetroFramework.Controls.MetroButton();
            this.btnadd = new MetroFramework.Controls.MetroButton();
            this.btnafisare = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.SpringGreen;
            this.metroPanel1.Controls.Add(this.btninapoi);
            this.metroPanel1.Controls.Add(this.btncautare);
            this.metroPanel1.Controls.Add(this.btnadd);
            this.metroPanel1.Controls.Add(this.btnafisare);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(162, 387);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btninapoi
            // 
            this.btninapoi.Location = new System.Drawing.Point(24, 286);
            this.btninapoi.Name = "btninapoi";
            this.btninapoi.Size = new System.Drawing.Size(118, 46);
            this.btninapoi.TabIndex = 5;
            this.btninapoi.Text = "Inapoi la Meniu";
            this.btninapoi.Click += new System.EventHandler(this.btninapoi_Click);
            // 
            // btncautare
            // 
            this.btncautare.Location = new System.Drawing.Point(24, 199);
            this.btncautare.Name = "btncautare";
            this.btncautare.Size = new System.Drawing.Size(118, 46);
            this.btncautare.TabIndex = 4;
            this.btncautare.Text = "Cautare Calculator";
            this.btncautare.Click += new System.EventHandler(this.btncautare_Click);
            // 
            // btnadd
            // 
            this.btnadd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnadd.Location = new System.Drawing.Point(22, 28);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(118, 46);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Adauga Calculator";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnafisare
            // 
            this.btnafisare.Location = new System.Drawing.Point(22, 104);
            this.btnafisare.Name = "btnafisare";
            this.btnafisare.Size = new System.Drawing.Size(117, 51);
            this.btnafisare.TabIndex = 6;
            this.btnafisare.Text = "Afisare Calculatoare";
            this.btnafisare.Click += new System.EventHandler(this.btnafisare_click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.SpringGreen;
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(159, 64);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1626, 10);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(167, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Nr. Locuri Sala";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(341, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(671, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "RAM";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(859, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "GPU";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(508, 82);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Procesor";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(1017, 82);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Pret";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(1193, 82);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Monitor";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(1428, 82);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Accesorii";
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 460);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "adminform";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Interfata Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminform_FormClosed);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void adminform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btninapoi_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormPrincipal meniuForm = new FormPrincipal();
            meniuForm.Show();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {

            FormAdd meniuForm = new FormAdd();
            meniuForm.Show();
        }



        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnadd;
        private MetroFramework.Controls.MetroButton btncautare;
        private MetroFramework.Controls.MetroButton btninapoi;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnafisare;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}