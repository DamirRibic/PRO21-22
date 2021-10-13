using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSŠMobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janez Novak";
            janez.beleziKlic(10, 1);
            Console.WriteLine(janez.ToString());

            Kupec60 alenka = new Kupec60();
            alenka.Ime = "Alenka Prinčič";
            alenka.beleziKlic(70,2);
            
            Console.WriteLine(alenka.ToString());
            Console.WriteLine("metoda GetType " + alenka.GetType());
            Console.WriteLine("metoda ToString " + alenka.ToString());
            Console.ReadLine();

        }

    }
}
