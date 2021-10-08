using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzijaVaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 na 10 je: " +PotencaIterativno(10));
            Console.WriteLine("2 na 10 je: " +PotencaRekurzivno(10));
            Console.WriteLine("7 Fibonaccijevo stevilo je: "+Fib(7));
            Console.WriteLine("3. naloga s členom 2: " + TretjaNaloga(2));
            Console.WriteLine("3. naloga s členom 5: "+TretjaNaloga(5));
            Console.WriteLine("4. naloga s členom 2: " + CetrtaNaloga(2));
            Console.WriteLine("4. naloga s členom 2: " + CetrtaNaloga(5));
            Console.WriteLine("5. naloga: " + PetaNaloga(10));
            Console.ReadLine();
        }
        
        static int Fib(int n)
        {
            if (n==1 || n==2)
                    return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static int PotencaIterativno(int n)
        {
            int potenca = 1;
            for (int k = 1; k <= n; k++)
            {
                potenca = potenca * 2;
            }
            return potenca;
        }
        static int PotencaRekurzivno(int n)
        {
            if (n == 0)
                return 1;
            return 2 * PotencaRekurzivno(n - 1);
        }
        static int TretjaNaloga(int n)
        {
            if (n == 1 || n == 2)
                return 2;
            return TretjaNaloga(n - 2) * TretjaNaloga(n - 1) - 1;
        }
        static int CetrtaNaloga(int n)
        {
            if (n == 1)
                return 2;
            return 3 * CetrtaNaloga(n - 1) + 2;
        }
        static int PetaNaloga(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return PetaNaloga(n - 1) * 2 + PetaNaloga(n - 2);
        }
    }
}
