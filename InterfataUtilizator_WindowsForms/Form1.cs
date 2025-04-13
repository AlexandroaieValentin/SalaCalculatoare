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
    public partial class Form1 : MetroForm
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

        private MetroButton btnadd;
        private MetroButton btnrefresh;
        private MetroButton btncautare;

        private List<MetroLabel> lblsid;
        private List<MetroLabel> lblsprocesor;
        private List<MetroLabel> lblsram;
        private List<MetroLabel> lblsgpu;
        private List<MetroLabel> lblspret;
        private List<MetroLabel> lblsmonitor;
        private List<MetroLabel> lblsaccesorii;
        private List<MetroLabel> lblscautare;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 150;


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



        public Form1()
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

            this.Size = new Size(1500, 800);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Consolas", 9, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.Text = "Informatii sala";


            lblsala = new MetroLabel();
            lblsala.Width = LATIME_CONTROL;
            lblsala.Text = "Locuri sala";
            lblsala.Left = DIMENSIUNE_PAS_X;
            lblsala.Top = 3 * DIMENSIUNE_PAS_Y;
            lblsala.ForeColor = Color.White;
            this.Controls.Add(lblsala);

            lblcautare = new MetroLabel();
            lblcautare.Width = LATIME_CONTROL;
            lblcautare.AutoSize = true;
            lblcautare.Text = "Cautare dupa ID";
            lblcautare.Top = 20 * DIMENSIUNE_PAS_Y;
            lblcautare.Left = DIMENSIUNE_PAS_X;
            lblcautare.ForeColor = Color.White;
            this.Controls.Add(lblcautare);

            lblid = new MetroLabel();
            lblid.Width = LATIME_CONTROL;
            lblid.Text = "ID";
            lblid.Top = 3 * DIMENSIUNE_PAS_Y;
            lblid.Left = 2 * DIMENSIUNE_PAS_X;
            lblid.ForeColor = Color.White;
            this.Controls.Add(lblid);

            lblprocesor = new MetroLabel();
            lblprocesor.Width = LATIME_CONTROL;
            lblprocesor.Text = "Procesor";
            lblprocesor.Top = 3 * DIMENSIUNE_PAS_Y;
            lblprocesor.Left = 3 * DIMENSIUNE_PAS_X;
            lblprocesor.ForeColor = Color.White;
            this.Controls.Add(lblprocesor);

            lblram = new MetroLabel();
            lblram.Width = LATIME_CONTROL;
            lblram.Text = "RAM";
            lblram.Top = 3 * DIMENSIUNE_PAS_Y;
            lblram.Left = 4 * DIMENSIUNE_PAS_X;
            lblram.ForeColor = Color.White;
            this.Controls.Add(lblram);

            lblgpu = new MetroLabel();
            lblgpu.Width = LATIME_CONTROL;
            lblgpu.Text = "GPU";
            lblgpu.Top = 3 * DIMENSIUNE_PAS_Y;
            lblgpu.Left = 5 * DIMENSIUNE_PAS_X;
            lblgpu.ForeColor = Color.White;
            this.Controls.Add(lblgpu);

            lblpret = new MetroLabel();
            lblpret.Width = LATIME_CONTROL;
            lblpret.Text = "Pret";
            lblpret.Top = 3 * DIMENSIUNE_PAS_Y;
            lblpret.Left = 6 * DIMENSIUNE_PAS_X;
            lblpret.ForeColor = Color.White;
            this.Controls.Add(lblpret);

            lblmonitor = new MetroLabel();
            lblmonitor.Width = LATIME_CONTROL;
            lblmonitor.Top = 3 * DIMENSIUNE_PAS_Y;
            lblmonitor.Text = "Monitor";
            lblmonitor.Left = 7 * DIMENSIUNE_PAS_X;
            lblmonitor.ForeColor = Color.White;
            this.Controls.Add(lblmonitor);

            lblaccesorii = new MetroLabel();
            lblaccesorii.Width = LATIME_CONTROL;
            lblaccesorii.Top = 3 * DIMENSIUNE_PAS_Y;
            lblaccesorii.Text = "Accesorii";
            lblaccesorii.Left = 8 * DIMENSIUNE_PAS_X;
            lblaccesorii.ForeColor = Color.White;
            this.Controls.Add(lblaccesorii);


            txtid = new MetroTextBox();
            txtid.Top = 13 * DIMENSIUNE_PAS_Y;
            txtid.Width = LATIME_CONTROL;
            txtid.Left = 2 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtid);

            txtcautare = new MetroTextBox();
            txtcautare.Top = 20 * DIMENSIUNE_PAS_Y;
            txtcautare.Width = LATIME_CONTROL;
            txtcautare.Left = 2 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtcautare);

            txtprocesor = new MetroTextBox();
            txtprocesor.Top = 13 * DIMENSIUNE_PAS_Y;
            txtprocesor.Width = LATIME_CONTROL;
            txtprocesor.Left = 3 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtprocesor);

            txtram = new MetroTextBox();
            txtram.Top = 13 * DIMENSIUNE_PAS_Y;
            txtram.Width = LATIME_CONTROL;
            txtram.Left = 4 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtram);

            txtgpu = new MetroTextBox();
            txtgpu.Top = 13 * DIMENSIUNE_PAS_Y;
            txtgpu.Width = LATIME_CONTROL;
            txtgpu.Left = 5 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtgpu);

            txtpret = new MetroTextBox();
            txtpret.Top = 13 * DIMENSIUNE_PAS_Y;
            txtpret.Width = LATIME_CONTROL;
            txtpret.Left = 6 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtpret);

            txtmonitor = new MetroTextBox();
            txtmonitor.Top = 13 * DIMENSIUNE_PAS_Y;
            txtmonitor.Width = LATIME_CONTROL;
            txtmonitor.Left = 7 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtmonitor);

            txtaccesorii = new MetroTextBox();
            txtaccesorii.Top = 13 * DIMENSIUNE_PAS_Y;
            txtaccesorii.Width = LATIME_CONTROL;
            txtaccesorii.Left = 8 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtaccesorii);

            txtsala = new MetroTextBox();
            txtsala.Top = 13 * DIMENSIUNE_PAS_Y;
            txtsala.Width = LATIME_CONTROL;
            txtsala.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtsala);



            btnadd = new MetroButton();
            btnadd.Text = "Adauga calculator";
            btnadd.Width = LATIME_CONTROL;
            btnadd.AutoSize = true;
            btnadd.Location = new Point(150, 500);
            btnadd.Click += btnclick;
            this.Controls.Add(btnadd);

            btnrefresh = new MetroButton();
            btnrefresh.Text = "Refresh";
            btnrefresh.Width = LATIME_CONTROL;
            btnrefresh.AutoSize = true;
            btnrefresh.Location = new Point(150, 550);
            btnrefresh.Click += butonrefresh;
            this.Controls.Add(btnrefresh);

            btncautare = new MetroButton();
            btncautare.Text = "Cauta calculator";
            btncautare.Width = LATIME_CONTROL;
            btncautare.Location = new Point(450, 600);
            btncautare.Click += btncautare_Click;
            this.Controls.Add(btncautare);



            lblErrorId = new MetroLabel();
            lblErrorId.AutoSize = true;
            lblErrorId.ForeColor = Color.Red;
            lblErrorId.Left = txtid.Left;
            lblErrorId.Top = txtid.Bottom + 5;
            this.Controls.Add(lblErrorId);

            lblErrorProcesor = new MetroLabel();
            lblErrorProcesor.ForeColor = Color.Red;
            lblErrorProcesor.Left = txtprocesor.Left;
            lblErrorProcesor.Top = txtprocesor.Bottom + 5;
            lblErrorProcesor.AutoSize = true;
            this.Controls.Add(lblErrorProcesor);

            lblErrorRam = new MetroLabel();
            lblErrorRam.ForeColor = Color.Red;
            lblErrorRam.Left = txtram.Left;
            lblErrorRam.Top = txtram.Bottom + 5;
            lblErrorRam.AutoSize = true;
            this.Controls.Add(lblErrorRam);

            lblErrorGpu = new MetroLabel();
            lblErrorGpu.ForeColor = Color.Red;
            lblErrorGpu.Left = txtgpu.Left;
            lblErrorGpu.Top = txtgpu.Bottom + 5;
            lblErrorGpu.AutoSize = true;
            this.Controls.Add(lblErrorGpu);

            lblErrorPret = new MetroLabel();
            lblErrorPret.ForeColor = Color.Red;
            lblErrorPret.Left = txtpret.Left;
            lblErrorPret.Top = txtpret.Bottom + 5;
            lblErrorPret.AutoSize = true;
            this.Controls.Add(lblErrorPret);

            lblErrorMonitor = new MetroLabel();
            lblErrorMonitor.ForeColor = Color.Red;
            lblErrorMonitor.Left = txtmonitor.Left;
            lblErrorMonitor.Top = txtmonitor.Bottom + 5;
            lblErrorMonitor.AutoSize = true;
            this.Controls.Add(lblErrorMonitor);

            lblErrorAccesorii = new MetroLabel();
            lblErrorAccesorii.ForeColor = Color.Red;
            lblErrorAccesorii.Left = txtaccesorii.Left;
            lblErrorAccesorii.Top = txtaccesorii.Bottom + 5;
            lblErrorAccesorii.AutoSize = true;
            this.Controls.Add(lblErrorAccesorii);

            lblErrorSala = new MetroLabel();
            lblErrorSala.ForeColor = Color.Red;
            lblErrorSala.Left = txtsala.Left;
            lblErrorSala.Top = txtsala.Bottom + 5;
            lblErrorSala.AutoSize = true;
            this.Controls.Add(lblErrorSala);

            lblErrorCaut = new MetroLabel();
            lblErrorCaut.ForeColor = Color.Red;
            lblErrorCaut.Left = txtcautare.Left;
            lblErrorCaut.Top = txtcautare.Bottom + 5;
            lblErrorCaut.AutoSize = true;
            this.Controls.Add(lblErrorCaut);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareCalculator();
            AfisareSala();
        }

        private void btnclick(object sender, EventArgs e)
        {
            ResetareMesajeEroare();

            bool areErori = false;

            if (!int.TryParse(txtid.Text, out int id) || id < MIN_ID)
            {
                lblErrorId.Text = "ID invalid";
                areErori = true;
            }

            if (string.IsNullOrWhiteSpace(txtprocesor.Text))
            {
                lblErrorProcesor.Text = "Procesor invalid";
                areErori = true;
            }

            if (!int.TryParse(txtram.Text, out int ram) || ram < MIN_RAM || ram > MAX_RAM)
            {
                lblErrorRam.Text = "RAM invalid";
                areErori = true;
            }

            if (string.IsNullOrWhiteSpace(txtgpu.Text))
            {
                lblErrorGpu.Text = "GPU invalid";
                areErori = true;
            }

            if (!int.TryParse(txtpret.Text, out int pret) || pret < MIN_PRET || pret > MAX_PRET)
            {
                lblErrorPret.Text = "Preț invalid";
                areErori = true;
            }

            if (!Enum.TryParse(txtmonitor.Text, out TipEcran monitor))
            {
                lblErrorMonitor.Text = "Monitor invalid";
                areErori = true;
            }

            if (!Enum.TryParse(txtaccesorii.Text, out Accesorii accesorii))
            {
                lblErrorAccesorii.Text = "Accesorii invalide";
                areErori = true;
            }

            if (!int.TryParse(txtsala.Text, out int capacitate) || capacitate < MIN_CAPACITATE_SALA || capacitate > MAX_CAPACITATE_SALA)
            {
                lblErrorSala.Text = "Nr. locuri invalid";
                areErori = true;
            }

            if (areErori) return;

            Calculator calc1 = new Calculator(id, txtprocesor.Text, ram, txtgpu.Text, pret, monitor, accesorii);
            admincalc.AddCalculator(calc1);

            Sala sala1 = new Sala(0);
            sala1.capacitate = capacitate;
            adminsala.LocuriCamera(sala1);

        }

        private void btncautare_Click(object sender, EventArgs e)
        {
            ResetareMesajeEroare();
            AfisareCalculator();
            AfisareSala();

            if (lblscautare != null)
            {
                foreach (var lbl in lblscautare)
                {
                    this.Controls.Remove(lbl);
                    lbl.Dispose();
                }
                lblscautare.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtcautare.Text))
            {
                lblErrorCaut.Text = "Cautare invalida";
                return;
            }

            if (!int.TryParse(txtcautare.Text, out int idCautat))
            {
                lblErrorCaut.Text = "ID-ul trebuie sa fie un numar";
                return;
            }

            List<Calculator> calculatoare = admincalc.GetCalculatoare();
            List<Calculator> calculatoareGasite = calculatoare.Where(c => c.id == idCautat).ToList();

            if (calculatoareGasite.Count > 0)
            {
                lblscautare = new List<MetroLabel>();
                foreach (Calculator calc in calculatoareGasite)
                {
                    MetroLabel lblCautat = new MetroLabel();
                    lblCautat.Width = LATIME_CONTROL;
                    lblCautat.Text = calc.ToString();
                    lblCautat.Left = 2 * DIMENSIUNE_PAS_X;
                    lblCautat.Top = 22 * DIMENSIUNE_PAS_Y;
                    lblCautat.ForeColor = Color.White;
                    lblCautat.AutoSize = true;
                    this.Controls.Add(lblCautat);
                    lblscautare.Add(lblCautat);
                }
            }
            else
            {
                lblErrorCaut.Text = "Calculatorul nu a fost gasit";
            }
        }
        private void butonrefresh(object sender, EventArgs e)
        {
            AfisareCalculator();
            AfisareSala();
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
                lblUltimaSalaAfisata.Left = DIMENSIUNE_PAS_X;
                lblUltimaSalaAfisata.Top = 4 * DIMENSIUNE_PAS_Y;
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
                lblIdCalc.Left = 2 * DIMENSIUNE_PAS_X;
                lblIdCalc.Top = (index + 4) * DIMENSIUNE_PAS_Y;
                lblIdCalc.ForeColor = Color.White;
                this.Controls.Add(lblIdCalc);
                lblsid.Add(lblIdCalc);


                MetroLabel lblProc = new MetroLabel();
                lblProc.Width = LATIME_CONTROL;
                lblProc.Text = calc.procesor;
                lblProc.Left = 3 * DIMENSIUNE_PAS_X;
                lblProc.Top = (index + 4) * DIMENSIUNE_PAS_Y;
                lblProc.ForeColor = Color.White;
                this.Controls.Add(lblProc);
                lblsprocesor.Add(lblProc);


                MetroLabel lblRam = new MetroLabel();
                lblRam.Width = LATIME_CONTROL;
                lblRam.Text = calc.ram.ToString();
                lblRam.Left = 4 * DIMENSIUNE_PAS_X;
                lblRam.Top = (index + 4) * DIMENSIUNE_PAS_Y;
                lblRam.ForeColor = Color.White;
                this.Controls.Add(lblRam);
                lblsram.Add(lblRam);


                MetroLabel lblGpu = new MetroLabel();
                lblGpu.Width = LATIME_CONTROL;
                lblGpu.Text = calc.gpu;
                lblGpu.Left = 5 * DIMENSIUNE_PAS_X;
                lblGpu.Top = (index + 4) * DIMENSIUNE_PAS_Y;
                lblGpu.ForeColor = Color.White;
                this.Controls.Add(lblGpu);
                lblsgpu.Add(lblGpu);


                MetroLabel lblPret = new MetroLabel();
                lblPret.Width = LATIME_CONTROL;
                lblPret.Text = calc.pret.ToString();
                lblPret.Left = 6 * DIMENSIUNE_PAS_X;
                lblPret.Top = (index + 4) * DIMENSIUNE_PAS_Y;
                lblPret.ForeColor = Color.White;
                this.Controls.Add(lblPret);
                lblspret.Add(lblPret);


                MetroLabel lblMonitor = new MetroLabel();
                lblMonitor.Width = LATIME_CONTROL;
                lblMonitor.Text = calc.Monitor.ToString();
                lblMonitor.Left = 7 * DIMENSIUNE_PAS_X;
                lblMonitor.Top = (index + 4) * DIMENSIUNE_PAS_Y;
                lblMonitor.ForeColor = Color.White;
                this.Controls.Add(lblMonitor);
                lblsmonitor.Add(lblMonitor);


                MetroLabel lblAccesorii = new MetroLabel();
                lblAccesorii.AutoSize = true;
                lblAccesorii.Text = calc.accesorii.ToString();
                lblAccesorii.Left = 8 * DIMENSIUNE_PAS_X;
                lblAccesorii.Top = (index + 4) * DIMENSIUNE_PAS_Y;
                lblAccesorii.ForeColor = Color.White;
                this.Controls.Add(lblAccesorii);
                lblsaccesorii.Add(lblAccesorii);

                index++;
            }
        }
        private void ResetareMesajeEroare()
        {
            lblErrorId.Text = "";
            lblErrorProcesor.Text = "";
            lblErrorRam.Text = "";
            lblErrorGpu.Text = "";
            lblErrorPret.Text = "";
            lblErrorMonitor.Text = "";
            lblErrorAccesorii.Text = "";
            lblErrorSala.Text = "";
            lblErrorCaut.Text = "";
        }


    }
}
