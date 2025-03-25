using System;
namespace LibrarieModele
{
    public class Sala
    {
        public int capacitate { get; set; }
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int CAP = 1;

        public Sala(int capacitate)
        {
            this.capacitate = capacitate;
        }
        public Sala(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.capacitate = Convert.ToInt32(dateFisier[CAP]);

        }
        public string ConversieSirFis()
        {
            string obiectsala = string.Format("{1}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                capacitate.ToString());
            return obiectsala;
        }
        public string Info()
        {
            return $"Capacitate sala: {capacitate}.";
        }

    }
}