using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareSala
    {
        private Sala[] sala1;
        private const int capmax = 50;
        private int indexmax;
    public AdministrareSala()
        {
            sala1 = new Sala[capmax];
            indexmax = 0;
        }
    public void LocuriCamera(Sala _sala)
        {
            sala1[indexmax] = _sala;
            indexmax++;
        }
    public Sala[] GetLocuri(out int indexmax)
        {
            indexmax = this.indexmax;
            return sala1;
        }

    }

}
