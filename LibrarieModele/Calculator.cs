
using System;

namespace LibrarieModele
{
    public class Calculator
    {
        public int id { get; set; }
        public string procesor { get; set; }
        public int ram { get; set; }
        public string gpu { get; set; }
        public int pret { get; set; }

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;

        private const int PROCESOR = 1;

        private const int RAM = 2;

        private const int GPU = 3;

        private const int PRET = 4;
        public Calculator()
        {
            id = ram = pret = -1;
            procesor = gpu = string.Empty;
        }

        public Calculator(int _id, string _procesor, int _ram, string _gpu, int _pret)
        {
            id = _id;
            procesor = _procesor;
            ram = _ram;
            gpu = _gpu;
            pret = _pret;
        }

        public Calculator(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.id = Convert.ToInt32(dateFisier[ID]);
            this.procesor = dateFisier[PROCESOR];
            this.ram = Convert.ToInt32(dateFisier[RAM]);
            this.gpu = dateFisier[GPU];
            this.pret = Convert.ToInt32(dateFisier[PRET]);
        }

        public string ConversieSirPtFisier()
        {
            string obiectCalc = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                id.ToString(),
                (procesor ?? "NECUNOSCUT"),
                ram.ToString(),
                (gpu ?? "NECUNOSCUT"),
                pret.ToString());
            return obiectCalc;

        }

        public string Info()
        {
            return $"ID: {id}, Procesor: {procesor}, RAM: {ram} GB, GPU: {gpu}, Pret pachet: {pret} lei";
        }
    }
}
