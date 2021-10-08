using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(beseda("ana"));
            Console.ReadLine();
        }
        static Boolean beseda(string n)
        {
            if (n.Length == 1 || n.Length == 0)
            {
                return true;
            }
            if (n[0] == n[n.Length - 1])
            {
                return beseda(n.Substring(1, n.Length - 2));
            }
            else
                return false;
        }
            
        

        }
    }



