using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using LibrarieModele;
using NivelStocareDate;

namespace InterfataUtilizator_WindowsForms
{
    public partial class FormCautare : MetroForm
    {
        public FormCautare()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void btncautare_Click(object sender, EventArgs e)
        {

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = Path.Combine(locatieFisierSolutie, numeFisier);

            AdministrareCalculatoare_FisierText admincalc = new AdministrareCalculatoare_FisierText(caleCompletaFisier);


            foreach (Control control in this.Controls.OfType<MetroLabel>().Where(c => c.Name.StartsWith("lblCaut_")).ToList())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }


            if (string.IsNullOrWhiteSpace(txtcautare.Text))
            {
                MessageBox.Show(this, "Căutare invalidă. Introdu un ID.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtcautare.Text, out int idCautat))
            {
                MessageBox.Show(this, "ID-ul trebuie să fie un număr.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<Calculator> calculatoare = admincalc.GetCalculatoare();
            List<Calculator> calculatoareGasite = calculatoare.Where(c => c.id == idCautat).ToList();

            if (calculatoareGasite.Count > 0)
            {
                int verticalOffset = 0;

                foreach (Calculator calc in calculatoareGasite)
                {
                    List<string> infoCalculator = new List<string>
        {
            $"Calculatorul găsit:",
            $"ID: {calc.id}",
            $"Procesor: {calc.procesor}",
            $"RAM: {calc.ram}",
            $"GPU: {calc.gpu}",
            $"Preț: {calc.pret}",
            $"Monitor: {calc.Monitor}",
            $"Accesorii: {calc.accesorii}"
        };

                    foreach (string info in infoCalculator)
                    {
                        MetroLabel lblCautat = new MetroLabel();
                        lblCautat.Name = $"lblCaut_{calc.id}_{verticalOffset}";
                        lblCautat.Text = info;
                        lblCautat.Left = 80;
                        lblCautat.Top = 220 + verticalOffset;
                        lblCautat.AutoSize = true;
                        lblCautat.Style = MetroColorStyle.Blue;

                        this.Controls.Add(lblCautat);
                        verticalOffset += 25;
                    }

                    verticalOffset += 10;
                }
            }

            else
            {
                MessageBox.Show(this, "Calculatorul nu a fost găsit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
