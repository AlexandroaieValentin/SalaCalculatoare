
using LibrarieModele;
using System;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareCalculatoare_FisierText
    {
        private const int NrMax = 50;
        private string numeFisier;

        public AdministrareCalculatoare_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();

        }
        public void AddCalculator(Calculator _calc)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(_calc.ConversieSirPtFisier());
            }
        }
        public Calculator[] GetCalculator(out int indexcalc)
        {
            Calculator[] calc = new Calculator[NrMax];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                indexcalc = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    calc[indexcalc++] = new Calculator(linieFisier);
                }
            }
            return calc;

        }
        public Calculator[] GetPret(int pretCautat, out int nrRezultate)
        {
            Calculator[] toateCalculatoarele = GetCalculator(out int numarCalculatoare);
            Calculator[] rezultate = new Calculator[numarCalculatoare];
            nrRezultate = 0;

            for (int i = 0; i < numarCalculatoare; i++)
            {
                if (toateCalculatoarele[i].pret == pretCautat)
                {
                    rezultate[nrRezultate] = toateCalculatoarele[i];
                    nrRezultate++;
                }
            }
            return rezultate;
        }
    }
}
