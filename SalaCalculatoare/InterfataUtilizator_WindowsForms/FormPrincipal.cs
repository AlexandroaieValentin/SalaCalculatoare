using LibrarieModele;
using LibrarieModele.Enumerari;
using MetroFramework.Forms;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace InterfataUtilizator_WindowsForms
{
    public partial class FormPrincipal : MetroForm
    {
        private Panel principal; 

        public FormPrincipal()
        {
            InitializeComponent();
            principal = new Panel(); 
            principal.Dock = DockStyle.Fill; 
            this.Controls.Add(principal); 
        }



        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            adminform adminForm = new adminform(); 
            adminForm.Show();                      
            this.Hide();                           
        }

    }
}
