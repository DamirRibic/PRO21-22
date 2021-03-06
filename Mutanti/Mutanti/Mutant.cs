using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    abstract class Mutant : IPrikazovalnik
    {
        public int Ime { get; set; }
        public int Stopnja { get; set; }

        public abstract int KvocientNevarnosti();
        public void prikaziInformacije()
        {
            Console.WriteLine("**************MUTANT****************");
            Console.WriteLine(Ime);
            Console.WriteLine("Kvocient nevarnosti"+KvocientNevarnosti());
        }
    }
}
