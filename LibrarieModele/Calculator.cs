
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

        public string Info()
        {
            return $"ID: {id}, Procesor: {procesor}, RAM: {ram} GB, GPU: {gpu}, Pret pachet: {pret} lei";
        }
    }
}
