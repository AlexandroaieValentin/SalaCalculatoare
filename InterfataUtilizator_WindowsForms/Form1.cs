using LibrarieModele;
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
        private Label lblid;
        private Label lblprocesor;
        private Label lblram;
        private Label lblgpu;
        private Label lblpret;
        private Label lblmonitor;
        private Label lblaccesorii;
        
        private Label lblsala;

        private Label[] lblsid;
        private Label[] lblsprocesor;
        private Label[] lblsram;
        private Label[] lblsgpu;
        private Label[] lblspret;
        private Label[] lblsmonitor;
        private Label[] lblsaccesorii;


        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 150;
        public Form1()
        {
            InitializeComponent();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            admincalc = new AdministrareCalculatoare_FisierText(caleCompletaFisier);
            int indexcalc = 0;
            Calculator[] calculatoareExistente = admincalc.GetCalculator(out indexcalc);

            string numeFisier2 = ConfigurationManager.AppSettings["NumeFisier2"];
            string locatieFisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatieFisierSolutie2 + "\\" + numeFisier2;
            adminsala = new AdministrareSalaFisier(caleCompletaFisier2);
            int indexmax = 0;
            Sala[] salas = adminsala.GetLocuri(out indexmax);

            this.Size = new Size(1500, 250);
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
            lblid.Left = 2*DIMENSIUNE_PAS_X;
            lblid.ForeColor = Color.White;
            this.Controls.Add(lblid);

            lblprocesor = new Label();
            lblprocesor.Width = LATIME_CONTROL;
            lblprocesor.Text = "Procesor";
            lblprocesor.Left = 3*DIMENSIUNE_PAS_X;
            lblprocesor.ForeColor = Color.White;
            this.Controls.Add(lblprocesor);

            lblram = new Label();
            lblram.Width = LATIME_CONTROL;
            lblram.Text = "RAM";
            lblram.Left = 4*DIMENSIUNE_PAS_X;
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
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareCalculator();
            AfisareSala();
        }

        private void AfisareSala()
        {
            Sala[] sali = adminsala.GetLocuri(out int indexmax);
            if (indexmax > 0)
            {
                Sala ultimaSala = sali[indexmax - 1];

                Label lblUltimaSala = new Label();
                lblUltimaSala.Width = LATIME_CONTROL;
                lblUltimaSala.Text = string.Join(" ", ultimaSala.capacitate);
                lblUltimaSala.Left = DIMENSIUNE_PAS_X;
                lblUltimaSala.Top = DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblUltimaSala);
            }
        }
        private void AfisareCalculator()
        {
            Calculator[] calculatoare = admincalc.GetCalculator(out int indexcalc).Take(indexcalc).ToArray();
            lblsid = new Label[indexcalc];
            lblsprocesor = new Label[indexcalc];
            lblsram = new Label[indexcalc];
            lblsgpu = new Label[indexcalc];
            lblspret = new Label[indexcalc];
            lblsmonitor = new Label[indexcalc];
            lblsaccesorii = new Label[indexcalc];


            int i = 0;

            foreach (Calculator calc in calculatoare)
            {
                lblsid[i] = new Label();
                lblsid[i].Width = LATIME_CONTROL;
                lblsid[i].Text = string.Join(" ", calc.id);
                lblsid[i].Left = 2*DIMENSIUNE_PAS_X;
                lblsid[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsid[i]);

                lblsprocesor[i] = new Label();
                lblsprocesor[i].Width = LATIME_CONTROL;
                lblsprocesor[i].Text = calc.procesor;
                lblsprocesor[i].Left = 3*DIMENSIUNE_PAS_X;
                lblsprocesor[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsprocesor[i]);

                lblsram[i] = new Label();
                lblsram[i].Width = LATIME_CONTROL;
                lblsram[i].Text = string.Join(" ", calc.ram);
                lblsram[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsram[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsram[i]);

                lblsgpu[i] = new Label();
                lblsgpu[i].Width = LATIME_CONTROL;
                lblsgpu[i].Text = calc.gpu;
                lblsgpu[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsgpu[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsgpu[i]);

                lblspret[i] = new Label();
                lblspret[i].Width = LATIME_CONTROL;
                lblspret[i].Text = string.Join(" ", calc.pret);
                lblspret[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblspret[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblspret[i]);

                lblsmonitor[i] = new Label();
                lblsmonitor[i].Width = LATIME_CONTROL;
                lblsmonitor[i].Text = string.Join(" ", calc.Monitor);
                lblsmonitor[i].Left = 7 * DIMENSIUNE_PAS_X;
                lblsmonitor[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsmonitor[i]);

                lblsaccesorii[i] = new Label();
                lblsaccesorii[i].AutoSize = true;
                lblsaccesorii[i].Text = string.Join(" ", calc.accesorii);
                lblsaccesorii[i].Left = 8 * DIMENSIUNE_PAS_X;
                lblsaccesorii[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsaccesorii[i]);
                i++;
            }
        }
    }
}
    


