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

    public partial class adminform : MetroForm
    {
        AdministrareCalculatoare_FisierText admincalc;
        AdministrareSalaFisier adminsala;

        private MetroLabel lblUltimaSalaAfisata;
        private MetroLabel lblid;
        private MetroLabel lblprocesor;
        private MetroLabel lblram;
        private MetroLabel lblgpu;
        private MetroLabel lblpret;
        private MetroLabel lblmonitor;
        private MetroLabel lblaccesorii;
        private MetroLabel lblsala;
        private MetroLabel lblcautare;

        private MetroTextBox txtid;
        private MetroTextBox txtprocesor;
        private MetroTextBox txtram;
        private MetroTextBox txtgpu;
        private MetroTextBox txtpret;
        private MetroTextBox txtmonitor;
        private MetroTextBox txtaccesorii;
        private MetroTextBox txtsala;
        private MetroTextBox txtcautare;



        private List<MetroLabel> lblsid;
        private List<MetroLabel> lblsprocesor;
        private List<MetroLabel> lblsram;
        private List<MetroLabel> lblsgpu;
        private List<MetroLabel> lblspret;
        private List<MetroLabel> lblsmonitor;
        private List<MetroLabel> lblsaccesorii;
        private List<MetroLabel> lblscautare;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 25;
        private const int DIMENSIUNE_PAS_X = 170;


        private const int MIN_ID = 1;
        private const int MAX_RAM = 128;
        private const int MIN_RAM = 1;
        private const int MAX_PRET = 100;
        private const int MIN_PRET = 5;
        private const int MAX_CAPACITATE_SALA = 50;
        private const int MIN_CAPACITATE_SALA = 1;

        private MetroLabel lblErrorId;
        private MetroLabel lblErrorProcesor;
        private MetroLabel lblErrorRam;
        private MetroLabel lblErrorGpu;
        private MetroLabel lblErrorPret;
        private MetroLabel lblErrorMonitor;
        private MetroLabel lblErrorAccesorii;
        private MetroLabel lblErrorSala;
        private MetroLabel lblErrorCaut;
        public adminform()
        {
            InitializeComponent();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            admincalc = new AdministrareCalculatoare_FisierText(caleCompletaFisier);

            string numeFisier2 = ConfigurationManager.AppSettings["NumeFisier2"];
            string locatieFisierSolutie2 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatieFisierSolutie2 + "\\" + numeFisier2;
            adminsala = new AdministrareSalaFisier(caleCompletaFisier2);

        }
        private void btnafisare_click(object sender, EventArgs e)
        {
            AfisareSala();
            AfisareCalculator();
        }
        private void AfisareSala()
        {
            if (lblUltimaSalaAfisata != null)
            {
                this.Controls.Remove(lblUltimaSalaAfisata);
                lblUltimaSalaAfisata.Dispose();
            }

            List<Sala> sali = adminsala.GetLocuri();
            if (sali.Count > 0)
            {
                Sala ultimaSala = sali[sali.Count - 1];
                lblUltimaSalaAfisata = new MetroLabel();
                lblUltimaSalaAfisata.Width = LATIME_CONTROL;
                lblUltimaSalaAfisata.Text = ultimaSala.capacitate.ToString();
                lblUltimaSalaAfisata.Left = 1*DIMENSIUNE_PAS_X;
                lblUltimaSalaAfisata.Top = 5 * DIMENSIUNE_PAS_Y;
                lblUltimaSalaAfisata.ForeColor = Color.White;
                this.Controls.Add(lblUltimaSalaAfisata);
            }
        }

        private void AfisareCalculator()
        {

            List<Calculator> calculatoare = admincalc.GetCalculatoare();


            lblsid = new List<MetroLabel>();
            lblsprocesor = new List<MetroLabel>();
            lblsram = new List<MetroLabel>();
            lblsgpu = new List<MetroLabel>();
            lblspret = new List<MetroLabel>();
            lblsmonitor = new List<MetroLabel>();
            lblsaccesorii = new List<MetroLabel>();

            int index = 0;
            foreach (Calculator calc in calculatoare)
            {

                MetroLabel lblIdCalc = new MetroLabel();
                lblIdCalc.Width = LATIME_CONTROL;
                lblIdCalc.Text = calc.id.ToString();
                lblIdCalc.Left = 2* DIMENSIUNE_PAS_X;
                lblIdCalc.Top = (index + 5) * DIMENSIUNE_PAS_Y;
                lblIdCalc.ForeColor = Color.White;
                this.Controls.Add(lblIdCalc);
                lblsid.Add(lblIdCalc);


                MetroLabel lblProc = new MetroLabel();
                lblProc.Width = LATIME_CONTROL;
                lblProc.Text = calc.procesor;
                lblProc.Left = 3 * DIMENSIUNE_PAS_X;
                lblProc.Top = (index + 5) * DIMENSIUNE_PAS_Y;
                lblProc.ForeColor = Color.White;
                this.Controls.Add(lblProc);
                lblsprocesor.Add(lblProc);


                MetroLabel lblRam = new MetroLabel();
                lblRam.Width = LATIME_CONTROL;
                lblRam.Text = calc.ram.ToString();
                lblRam.Left = 4 * DIMENSIUNE_PAS_X;
                lblRam.Top = (index + 5) * DIMENSIUNE_PAS_Y;
                lblRam.ForeColor = Color.White;
                this.Controls.Add(lblRam);
                lblsram.Add(lblRam);


                MetroLabel lblGpu = new MetroLabel();
                lblGpu.Width = LATIME_CONTROL;
                lblGpu.Text = calc.gpu;
                lblGpu.Left = 5 * DIMENSIUNE_PAS_X;
                lblGpu.Top = (index + 5) * DIMENSIUNE_PAS_Y;
                lblGpu.ForeColor = Color.White;
                this.Controls.Add(lblGpu);
                lblsgpu.Add(lblGpu);


                MetroLabel lblPret = new MetroLabel();
                lblPret.Width = LATIME_CONTROL;
                lblPret.Text = calc.pret.ToString();
                lblPret.Left = 6 * DIMENSIUNE_PAS_X;
                lblPret.Top = (index + 5) * DIMENSIUNE_PAS_Y;
                lblPret.ForeColor = Color.White;
                this.Controls.Add(lblPret);
                lblspret.Add(lblPret);


                MetroLabel lblMonitor = new MetroLabel();
                lblMonitor.Width = LATIME_CONTROL;
                lblMonitor.Text = calc.Monitor.ToString();
                lblMonitor.Left = 7 * DIMENSIUNE_PAS_X;
                lblMonitor.Top = (index + 5) * DIMENSIUNE_PAS_Y;
                lblMonitor.ForeColor = Color.White;
                this.Controls.Add(lblMonitor);
                lblsmonitor.Add(lblMonitor);


                MetroLabel lblAccesorii = new MetroLabel();
                lblAccesorii.AutoSize = true;
                lblAccesorii.Text = calc.accesorii.ToString();
                lblAccesorii.Left = 8 * DIMENSIUNE_PAS_X;
                lblAccesorii.Top = (index + 5) * DIMENSIUNE_PAS_Y;
                lblAccesorii.ForeColor = Color.White;
                this.Controls.Add(lblAccesorii);
                lblsaccesorii.Add(lblAccesorii);

                index++;
            }
        }

        private void btncautare_Click(object sender, EventArgs e)
        {
            var formcau = new FormCautare();
            formcau.ShowDialog();
        }
    }
}
