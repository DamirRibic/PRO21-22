using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanojskiStolpi
{
    class Program
    {
        static void Main(string[] args)
        {
            premakni(3, "a", "c", "b");
            Console.ReadLine();
        }
        static void premakni(int n, string zacetni, string koncni, string pomozni)
        {
            if (n == 1)
            {
                Console.WriteLine("Premakni iz "+zacetni+" na "+koncni);
                return;
            }
            premakni(n - 1, zacetni, pomozni, koncni); //iz a na b, pomagaj si s c
            Console.WriteLine("Premakni iz " + zacetni + " na " + koncni);
            premakni(n - 1, pomozni, koncni, zacetni);
            
        }
    }
}
