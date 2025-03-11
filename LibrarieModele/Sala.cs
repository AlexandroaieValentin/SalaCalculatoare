
namespace LibrarieModele
{
    public class Sala
    {
        public int capacitate { get; set; }
        public int nrcamere { get; set; }
        
        public Sala()
        {
            capacitate = -1;
            nrcamere = -1;
        }
        public Sala(int _capacitate, int _nrcamere)
        {
            capacitate = _capacitate;
            nrcamere = _nrcamere;
            
        }
        public string Info()
        {
            return $"Capacitate sala: {capacitate}, Camere disponibile in sala: {nrcamere}.";
        }

    }
}
