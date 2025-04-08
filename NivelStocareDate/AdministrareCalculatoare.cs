using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareCalculatoare_FisierText
    {
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

        public List<Calculator> GetCalculatoare()
        {
            List<Calculator> calculatoare = new List<Calculator>();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    calculatoare.Add(new Calculator(linieFisier));
                }
            }
            return calculatoare;
        }

        public List<Calculator> GetCalculatoareByPret(int pretCautat)
        {
            List<Calculator> toateCalculatoarele = GetCalculatoare();
            List<Calculator> rezultate = toateCalculatoarele.Where(calc => calc.pret == pretCautat).ToList();
            return rezultate;
        }
    }
}
