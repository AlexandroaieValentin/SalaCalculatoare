using LibrarieModele;
using System;

namespace NivelStocareDate
{
    public class AdministrareCalculatoare
    {
        private Calculator[] calc;
        private const int NrMax = 50;
        private int indexcalc;
    
    public AdministrareCalculatoare()
        {
            calc = new Calculator[NrMax];
            indexcalc = 0;

        }
     public void AddCalculator(Calculator _calc)
        {
            calc[indexcalc] = _calc;
            indexcalc++;
        }
     public Calculator[] GetCalculator(out int indexcalc)
        {
            indexcalc = this.indexcalc;
            return calc;
        }
    public Calculator[] GetPret(int pretCautat, out int nrRezultate)
        {
            Calculator[] rezultate = new Calculator[NrMax];
            nrRezultate = 0;
            for (int i = 0; i < indexcalc; i++) 
            {
                if (calc[i].pret == pretCautat)
                {
                    rezultate[nrRezultate] = calc[i];
                    nrRezultate++;
                }
            }
            return rezultate;
        }
    }
}
