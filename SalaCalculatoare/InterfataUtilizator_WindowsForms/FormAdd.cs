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
using System.Collections;
using MetroFramework;

namespace InterfataUtilizator_WindowsForms
{
    public partial class FormAdd : MetroForm
    {
        AdministrareCalculatoare_FisierText admincalc;
        AdministrareSalaFisier adminsala;
        private List<Accesorii> accsel = new List<Accesorii>();
        private const int MAX_RAM = 128;
        private const int MIN_RAM = 1;
        private const int MAX_PRET = 100;
        private const int MIN_PRET = 5;
        private const int MAX_CAPACITATE_SALA = 50;
        private const int MIN_CAPACITATE_SALA = 1;

        public FormAdd()
        {
            InitializeComponent();
        }
        private void btnadaugare_click(object sender, EventArgs e)
        {

            if (!ValideazaDate())
            {
                MessageBox.Show("Datele introduse nu sunt valide. Corectează câmpurile marcate cu roșu.");
                return;
            }
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string caleCompletaFisier = Path.Combine(locatieFisierSolutie, numeFisier);
            admincalc = new AdministrareCalculatoare_FisierText(caleCompletaFisier);

            string numeFisier2 = ConfigurationManager.AppSettings["NumeFisier2"];
            string caleCompletaFisier2 = Path.Combine(locatieFisierSolutie, numeFisier2);
            adminsala = new AdministrareSalaFisier(caleCompletaFisier2);

            int id = int.Parse(txtid.Text);
            string procesor = txtprocesor.Text;
            int ram = int.Parse(txtram.Text);
            string gpu = txtgpu.Text;
            int pret = int.Parse(txtpret.Text);
            TipEcran monitor = GetEcran();
            int capacitate = int.Parse(txtsala.Text);


            Accesorii accesoriiCombinat = Accesorii.Necunoscut;
            foreach (Accesorii acc in accsel)
            {
                accesoriiCombinat |= acc;
            }

            Calculator calculator = new Calculator(id, procesor, ram, gpu, pret, monitor, accesoriiCombinat);
            admincalc.AddCalculator(calculator);

            Sala sala = new Sala(0);
            sala.capacitate = capacitate;
            adminsala.LocuriCamera(sala);

        }


        private void cbk_CheckChanged(object sender, EventArgs e)
        {
            var cbk = sender as MetroCheckBox;

            if (cbk == null) return;
            string accesoriu = cbk.Text;

            if (Enum.TryParse(accesoriu, out Accesorii accesoriuEnum))
            {
                if (cbk.Checked)
                    accsel.Add(accesoriuEnum);
                else
                    accsel.Remove(accesoriuEnum);
            }
        }

        private TipEcran GetEcran()
        {
            if (btn240hz.Checked)
                return TipEcran.FullHD240hz;
            if (btn360hz.Checked)
                return TipEcran.FullHD360hz;
            if (btn600hz.Checked)
                return TipEcran.FullHD600hz;
            if (btn2k.Checked)
                return TipEcran._2k165hz;
            if (btn4k.Checked)
                return TipEcran._4k120hz;

            return TipEcran.FullHD240hz;
        }
        private bool ValideazaDate()
        {
            bool allValid = true;

            Action<MetroTextBox, MetroLabel, bool> styleTextbox = (tb, lbl, isValid) =>
            {
                tb.CustomForeColor = true;
                tb.ForeColor = isValid ? Color.Black : Color.Red;

                lbl.CustomForeColor = true;
                lbl.ForeColor = isValid ? Color.Black : Color.Red;

                if (!isValid) allValid = false;
            };

            Action<MetroCheckBox, bool> styleCheckBox = (cb, isValid) =>
            {
                cb.CustomForeColor = true;
                cb.ForeColor = isValid ? Color.Black : Color.Red;

                if (!isValid) allValid = false;
            };

            // Validare ID
            bool idValid = int.TryParse(txtid.Text, out int id) && id > 0;
            styleTextbox(txtid, lblid, idValid);

            // Validare procesor
            bool procesorValid = !string.IsNullOrWhiteSpace(txtprocesor.Text);
            styleTextbox(txtprocesor, lblprocesor, procesorValid);

            // Validare RAM
            bool ramValid = int.TryParse(txtram.Text, out int ram) && ram >= MIN_RAM && ram <= MAX_RAM;
            styleTextbox(txtram, lblram, ramValid);

            // Validare GPU
            bool gpuValid = !string.IsNullOrWhiteSpace(txtgpu.Text);
            styleTextbox(txtgpu, lblgpu, gpuValid);

            // Validare pret
            bool pretValid = int.TryParse(txtpret.Text, out int pret) && pret >= MIN_PRET && pret <= MAX_PRET;
            styleTextbox(txtpret, lblpret, pretValid);

            // Validare monitor
            bool monitorValid = btn240hz.Checked || btn360hz.Checked || btn600hz.Checked || btn2k.Checked || btn4k.Checked;
            lblmonitor.CustomForeColor = true;
            lblmonitor.ForeColor = monitorValid ? Color.Black : Color.Red;
            if (!monitorValid) allValid = false;

            // Validare accesorii
            bool accesoriiValid = accsel.Count > 0;
            lblaccesorii.CustomForeColor = true;
            lblaccesorii.ForeColor = accesoriiValid ? Color.Black : Color.Red;
            if (!accesoriiValid) allValid = false;

            // Validare sala
            bool salaValid = int.TryParse(txtsala.Text, out int capacitate) && capacitate >= MIN_CAPACITATE_SALA && capacitate <= MAX_CAPACITATE_SALA;
            styleTextbox(txtsala, lblsala, salaValid);

            return allValid;
        }


    }
}

