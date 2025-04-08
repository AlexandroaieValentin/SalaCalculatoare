using LibrarieModele;
using LibrarieModele.Enumerari;
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

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        AdministrareCalculatoare_FisierText admincalc;
        AdministrareSalaFisier adminsala;

        private Label lblUltimaSalaAfisata;
        private Label lblid;
        private Label lblprocesor;
        private Label lblram;
        private Label lblgpu;
        private Label lblpret;
        private Label lblmonitor;
        private Label lblaccesorii;
        private Label lblsala;

        private TextBox txtid;
        private TextBox txtprocesor;
        private TextBox txtram;
        private TextBox txtgpu;
        private TextBox txtpret;
        private TextBox txtmonitor;
        private TextBox txtaccesorii;
        private TextBox txtsala;

        private Button btnadd;
        private Button btnrefresh;

        private List<Label> lblsid;
        private List<Label> lblsprocesor;
        private List<Label> lblsram;
        private List<Label> lblsgpu;
        private List<Label> lblspret;
        private List<Label> lblsmonitor;
        private List<Label> lblsaccesorii;

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

        private Label lblErrorId;
        private Label lblErrorProcesor;
        private Label lblErrorRam;
        private Label lblErrorGpu;
        private Label lblErrorPret;
        private Label lblErrorMonitor;
        private Label lblErrorAccesorii;
        private Label lblErrorSala;



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

            this.Size = new Size(1500, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Consolas", 9, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.Text = "Informatii sala";


            lblsala = new Label();
            lblsala.Width = LATIME_CONTROL;
            lblsala.Text = "Locuri sala";
            lblsala.Left = DIMENSIUNE_PAS_X;
            lblsala.ForeColor = Color.White;
            this.Controls.Add(lblsala);

            lblid = new Label();
            lblid.Width = LATIME_CONTROL;
            lblid.Text = "ID";
            lblid.Left = 2 * DIMENSIUNE_PAS_X;
            lblid.ForeColor = Color.White;
            this.Controls.Add(lblid);

            lblprocesor = new Label();
            lblprocesor.Width = LATIME_CONTROL;
            lblprocesor.Text = "Procesor";
            lblprocesor.Left = 3 * DIMENSIUNE_PAS_X;
            lblprocesor.ForeColor = Color.White;
            this.Controls.Add(lblprocesor);

            lblram = new Label();
            lblram.Width = LATIME_CONTROL;
            lblram.Text = "RAM";
            lblram.Left = 4 * DIMENSIUNE_PAS_X;
            lblram.ForeColor = Color.White;
            this.Controls.Add(lblram);

            lblgpu = new Label();
            lblgpu.Width = LATIME_CONTROL;
            lblgpu.Text = "GPU";
            lblgpu.Left = 5 * DIMENSIUNE_PAS_X;
            lblgpu.ForeColor = Color.White;
            this.Controls.Add(lblgpu);

            lblpret = new Label();
            lblpret.Width = LATIME_CONTROL;
            lblpret.Text = "Pret";
            lblpret.Left = 6 * DIMENSIUNE_PAS_X;
            lblpret.ForeColor = Color.White;
            this.Controls.Add(lblpret);

            lblmonitor = new Label();
            lblmonitor.Width = LATIME_CONTROL;
            lblmonitor.Text = "Monitor";
            lblmonitor.Left = 7 * DIMENSIUNE_PAS_X;
            lblmonitor.ForeColor = Color.White;
            this.Controls.Add(lblmonitor);

            lblaccesorii = new Label();
            lblaccesorii.Width = LATIME_CONTROL;
            lblaccesorii.Text = "Accesorii";
            lblaccesorii.Left = 8 * DIMENSIUNE_PAS_X;
            lblaccesorii.ForeColor = Color.White;
            this.Controls.Add(lblaccesorii);


            txtid = new TextBox();
            txtid.Top = 5 * DIMENSIUNE_PAS_Y;
            txtid.Width = LATIME_CONTROL;
            txtid.Left = 2 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtid);

            txtprocesor = new TextBox();
            txtprocesor.Top = 5 * DIMENSIUNE_PAS_Y;
            txtprocesor.Width = LATIME_CONTROL;
            txtprocesor.Left = 3 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtprocesor);

            txtram = new TextBox();
            txtram.Top = 5 * DIMENSIUNE_PAS_Y;
            txtram.Width = LATIME_CONTROL;
            txtram.Left = 4 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtram);

            txtgpu = new TextBox();
            txtgpu.Top = 5 * DIMENSIUNE_PAS_Y;
            txtgpu.Width = LATIME_CONTROL;
            txtgpu.Left = 5 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtgpu);
            
            txtpret = new TextBox();
            txtpret.Top = 5 * DIMENSIUNE_PAS_Y;
            txtpret.Width = LATIME_CONTROL;
            txtpret.Left = 6 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtpret);

            txtmonitor = new TextBox();
            txtmonitor.Top = 5 * DIMENSIUNE_PAS_Y;
            txtmonitor.Width = LATIME_CONTROL;
            txtmonitor.Left = 7 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtmonitor);
            
            txtaccesorii = new TextBox();
            txtaccesorii.Top = 5 * DIMENSIUNE_PAS_Y;
            txtaccesorii.Width = LATIME_CONTROL;
            txtaccesorii.Left = 8 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtaccesorii);
            
            txtsala = new TextBox();
            txtsala.Top = 5 * DIMENSIUNE_PAS_Y;
            txtsala.Width = LATIME_CONTROL;
            txtsala.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtsala);

            
            
            btnadd = new Button();
            btnadd.Text = "Adauga calculator";
            btnadd.Width = LATIME_CONTROL;
            btnadd.Location = new Point(100, 250);
            btnadd.Click += btnclick;
            this.Controls.Add(btnadd);

            btnrefresh = new Button();
            btnrefresh.Text = "Refresh";
            btnrefresh.Width = LATIME_CONTROL;
            btnrefresh.Location = new Point(100, 300);
            btnrefresh.Click += butonrefresh;
            this.Controls.Add(btnrefresh);

            
            
            
            lblErrorId = new Label();
            lblErrorId.AutoSize = true;
            lblErrorId.ForeColor = Color.Red;
            lblErrorId.Left = txtid.Left;
            lblErrorId.Top = txtid.Bottom + 5;
            this.Controls.Add(lblErrorId);

            lblErrorProcesor = new Label();
            lblErrorProcesor.ForeColor = Color.Red;
            lblErrorProcesor.Left = txtprocesor.Left;
            lblErrorProcesor.Top = txtprocesor.Bottom + 5;
            lblErrorProcesor.AutoSize = true;
            this.Controls.Add(lblErrorProcesor);

            lblErrorRam = new Label();
            lblErrorRam.ForeColor = Color.Red;
            lblErrorRam.Left = txtram.Left;
            lblErrorRam.Top = txtram.Bottom + 5;
            lblErrorRam.AutoSize = true;
            this.Controls.Add(lblErrorRam);

            lblErrorGpu = new Label();
            lblErrorGpu.ForeColor = Color.Red;
            lblErrorGpu.Left = txtgpu.Left;
            lblErrorGpu.Top = txtgpu.Bottom + 5;
            lblErrorGpu.AutoSize = true;
            this.Controls.Add(lblErrorGpu);

            lblErrorPret = new Label();
            lblErrorPret.ForeColor = Color.Red;
            lblErrorPret.Left = txtpret.Left;
            lblErrorPret.Top = txtpret.Bottom + 5;
            lblErrorPret.AutoSize = true;
            this.Controls.Add(lblErrorPret);
            
            lblErrorMonitor = new Label();
            lblErrorMonitor.ForeColor = Color.Red;
            lblErrorMonitor.Left = txtmonitor.Left;
            lblErrorMonitor.Top = txtmonitor.Bottom + 5;
            lblErrorMonitor.AutoSize = true;
            this.Controls.Add(lblErrorMonitor);
            
            lblErrorAccesorii = new Label();
            lblErrorAccesorii.ForeColor = Color.Red;
            lblErrorAccesorii.Left = txtaccesorii.Left;
            lblErrorAccesorii.Top = txtaccesorii.Bottom + 5;
            lblErrorAccesorii.AutoSize = true;
            this.Controls.Add(lblErrorAccesorii);
            
            lblErrorSala = new Label();
            lblErrorSala.ForeColor = Color.Red;
            lblErrorSala.Left = txtsala.Left;
            lblErrorSala.Top = txtsala.Bottom + 5;
            lblErrorSala.AutoSize = true;
            this.Controls.Add(lblErrorSala);


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
                lblUltimaSalaAfisata = new Label();
                lblUltimaSalaAfisata.Width = LATIME_CONTROL;
                lblUltimaSalaAfisata.Text = ultimaSala.capacitate.ToString();
                lblUltimaSalaAfisata.Left = DIMENSIUNE_PAS_X;
                lblUltimaSalaAfisata.Top = DIMENSIUNE_PAS_Y;
                lblUltimaSalaAfisata.ForeColor = Color.White;
                this.Controls.Add(lblUltimaSalaAfisata);
            }
        }

        private void AfisareCalculator()
        {

            List<Calculator> calculatoare = admincalc.GetCalculatoare();


            lblsid = new List<Label>();
            lblsprocesor = new List<Label>();
            lblsram = new List<Label>();
            lblsgpu = new List<Label>();
            lblspret = new List<Label>();
            lblsmonitor = new List<Label>();
            lblsaccesorii = new List<Label>();

            int index = 0;
            foreach (Calculator calc in calculatoare)
            {

                Label lblIdCalc = new Label();
                lblIdCalc.Width = LATIME_CONTROL;
                lblIdCalc.Text = calc.id.ToString();
                lblIdCalc.Left = 2 * DIMENSIUNE_PAS_X;
                lblIdCalc.Top = (index + 1) * DIMENSIUNE_PAS_Y;
                lblIdCalc.ForeColor = Color.White;
                this.Controls.Add(lblIdCalc);
                lblsid.Add(lblIdCalc);


                Label lblProc = new Label();
                lblProc.Width = LATIME_CONTROL;
                lblProc.Text = calc.procesor;
                lblProc.Left = 3 * DIMENSIUNE_PAS_X;
                lblProc.Top = (index + 1) * DIMENSIUNE_PAS_Y;
                lblProc.ForeColor = Color.White;
                this.Controls.Add(lblProc);
                lblsprocesor.Add(lblProc);


                Label lblRam = new Label();
                lblRam.Width = LATIME_CONTROL;
                lblRam.Text = calc.ram.ToString();
                lblRam.Left = 4 * DIMENSIUNE_PAS_X;
                lblRam.Top = (index + 1) * DIMENSIUNE_PAS_Y;
                lblRam.ForeColor = Color.White;
                this.Controls.Add(lblRam);
                lblsram.Add(lblRam);


                Label lblGpu = new Label();
                lblGpu.Width = LATIME_CONTROL;
                lblGpu.Text = calc.gpu;
                lblGpu.Left = 5 * DIMENSIUNE_PAS_X;
                lblGpu.Top = (index + 1) * DIMENSIUNE_PAS_Y;
                lblGpu.ForeColor = Color.White;
                this.Controls.Add(lblGpu);
                lblsgpu.Add(lblGpu);


                Label lblPret = new Label();
                lblPret.Width = LATIME_CONTROL;
                lblPret.Text = calc.pret.ToString();
                lblPret.Left = 6 * DIMENSIUNE_PAS_X;
                lblPret.Top = (index + 1) * DIMENSIUNE_PAS_Y;
                lblPret.ForeColor = Color.White;
                this.Controls.Add(lblPret);
                lblspret.Add(lblPret);


                Label lblMonitor = new Label();
                lblMonitor.Width = LATIME_CONTROL;
                lblMonitor.Text = calc.Monitor.ToString();
                lblMonitor.Left = 7 * DIMENSIUNE_PAS_X;
                lblMonitor.Top = (index + 1) * DIMENSIUNE_PAS_Y;
                lblMonitor.ForeColor = Color.White;
                this.Controls.Add(lblMonitor);
                lblsmonitor.Add(lblMonitor);


                Label lblAccesorii = new Label();
                lblAccesorii.AutoSize = true;
                lblAccesorii.Text = calc.accesorii.ToString();
                lblAccesorii.Left = 8 * DIMENSIUNE_PAS_X;
                lblAccesorii.Top = (index + 1) * DIMENSIUNE_PAS_Y;
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
        }


    }
}
