using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareSalaFisier
    {
        private const int capmax = 50;
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
        public Sala[] GetLocuri(out int indexmax)
        {
            Sala[] salaa = new Sala[capmax];
            using (StreamReader streamReader = new StreamReader(numeFisier2))
            {
                string linieFisier;
                indexmax = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    salaa[indexmax++] = new Sala(linieFisier);
                }
            }
            return salaa;
        }

    }

}
