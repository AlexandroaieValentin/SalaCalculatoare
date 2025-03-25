
using System;
using System.Configuration;
using System.IO;
using LibrarieModele;
using LibrarieModele.Enumerari;
using NivelStocareDate;


namespace SalaCalculatoare
{
    class Program
    {
        static void Main()
        {

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string numeFisier2 = ConfigurationManager.AppSettings["NumeFisier2"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string locatieFisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            string caleCompletaFisier2 = locatieFisierSolutie2 + "\\" + numeFisier2;


            AdministrareCalculatoare_FisierText admincalc = new AdministrareCalculatoare_FisierText(caleCompletaFisier);
            AdministrareSalaFisier adminsala = new AdministrareSalaFisier(caleCompletaFisier2);


            Calculator calc1 = new Calculator();
            int indexcalc = 0;
            Calculator[] calculatoareExistente = admincalc.GetCalculator(out indexcalc);
            AfisareCalculatoare(calculatoareExistente, indexcalc);
            Console.WriteLine();

            Sala sala1 = new Sala(0);
            sala1 = CitireSalaTast();
            AfisareSala(sala1);
            adminsala.LocuriCamera(sala1);
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                calc1 = CitireCalcTastatura();
                AfisareCalculator(calc1);
                admincalc.AddCalculator(calc1);

            }
            Calculator[] calc = admincalc.GetCalculator(out indexcalc);
            AfisareCalculatoare(calc, indexcalc);
            Console.WriteLine();


            Console.WriteLine("Introduceti pretul pachetului cautat: ");
            int pretCautat = Convert.ToInt32(Console.ReadLine());

            Calculator[] rezultate = admincalc.GetPret(pretCautat, out int nrRezultate);

            if (nrRezultate > 0)
            {
                Console.WriteLine($"Exista {nrRezultate} pachet cu pretul {pretCautat} lei: ");
                AfisareCalculatoare(rezultate, nrRezultate);
            }
            else
            {
                Console.WriteLine("Nu exista niciun pachet cu pretul acesta.");
            }
        }
        public static Calculator CitireCalcTastatura()
        {
            Console.WriteLine("Introdu ID-ul calculatorului: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdu Procesorul calculatorului: ");
            string procesor = Console.ReadLine();
            Console.WriteLine("Introdu RAM-ul calculatorului: ");
            int ram = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdu GPU-ul calculatorului: ");
            string gpu = Console.ReadLine();
            Console.WriteLine("Introdu pretul pachetului: ");
            int pret = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Alege monitorul: ");
            foreach (TipEcran tip in Enum.GetValues(typeof(TipEcran)))
            {
                Console.WriteLine($"{(int)tip}. {tip}");
            }
            int opt = Convert.ToInt32(Console.ReadLine());
            TipEcran MonitorSelectat = (TipEcran)opt;

            Accesorii accesoriiSel = 0;
            Console.WriteLine("Selecteaza accesoriile pe care le vrei: ");
            foreach (Accesorii acc in Enum.GetValues(typeof(Accesorii)))
            {
                Console.WriteLine($"{(int)acc}.{acc}");
            }
            string[] accesoriiInput = Console.ReadLine().Split(',');
            foreach (string accstr in accesoriiInput)
            {
                if (int.TryParse(accstr, out int accVal))
                {
                    accesoriiSel |= (Accesorii)accVal;
                }
            }

            return new Calculator(id, procesor, ram, gpu, pret, MonitorSelectat, accesoriiSel);
        }
        public static void AfisareCalculator(Calculator calc)
        {
            string InfoCalc = string.Format("Calculatorul cu ID: {0}, are componentele {1}, {2}, {3}. Monitorul selectat este: {4}. Accesoriile selectate sunt: {5}, Pretul pachetului este {6} lei.",
                calc.id,
                calc.procesor ?? "--",
                calc.ram,
                calc.gpu ?? "--",
                calc.Monitor,
                calc.accesorii,
                calc.pret);
            Console.WriteLine(InfoCalc);
            Console.WriteLine();
        }
        public static void AfisareCalculatoare(Calculator[] calc1, int indexcalc)
        {
            Console.WriteLine("Calculatoarele sunt: ");
            for (int contor = 0; contor < indexcalc; contor++)
            {
                string InfoCalc = calc1[contor].Info();
                Console.WriteLine($"Calculator {contor + 1}: {InfoCalc}");
            }
        }
        public static Sala CitireSalaTast()
        {
            Console.WriteLine("Capacitatea maxima a salii este: ");
            int capacitate = Convert.ToInt32(Console.ReadLine());
            Sala sala1 = new Sala(capacitate);
            return sala1;
        }
        public static void AfisareSala(Sala sala1)
        {
            string InfoSala = string.Format("Sala are capacitatea maxima: {0}. ",
                sala1.capacitate);
            Console.WriteLine(InfoSala);
        }
    }
}
