using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele.Enumerari
{
    public enum TipEcran
    {
        FullHD240hz = 1,
        FullHD360hz = 2,
        FullHD600hz = 3,
        _2k165hz = 4,
        _4k120hz = 5
    };

    [Flags]
    public enum Accesorii
    {
        MouseOffice = 1,
        MouseGaming = 2,
        TastaturaOffice = 4,
        TastaturaGaming = 8,
        Casti_InEar = 16,
        Casti_OverEar = 32
    }
}
