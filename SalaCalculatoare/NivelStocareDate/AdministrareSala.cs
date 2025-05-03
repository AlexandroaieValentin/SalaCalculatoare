using System;
using System.Collections.Generic;
using System.IO;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareSalaFisier
    {
        private string numeFisier2;

        public AdministrareSalaFisier(string numeFisier2)
        {
            this.numeFisier2 = numeFisier2;
            Stream streamFisierText = File.Open(numeFisier2, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void LocuriCamera(Sala _sala)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier2, true))
            {
                streamWriterFisierText.WriteLine(_sala.ConversieSirFis());
            }
        }

        public List<Sala> GetLocuri()
        {
            List<Sala> sali = new List<Sala>();
            using (StreamReader streamReader = new StreamReader(numeFisier2))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    sali.Add(new Sala(linieFisier));
                }
            }
            return sali;
        }
    }
}
