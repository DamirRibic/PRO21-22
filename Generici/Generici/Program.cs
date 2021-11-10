using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generici
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack s = new Stack();
            //s.Push(1);
            //s.Push("dobro jutro");
            //s.Push(2.5);
            //double x = (double)s.Pop();
            //string y = (string)s.Pop();
            //Console.WriteLine(x);
            //Console.ReadLine();
            SkladGen<int> s = new SkladGen<int>();
            SkladGen<string> s1 = new SkladGen<string>();
            s.Push(1);
           
        }
    }
}
