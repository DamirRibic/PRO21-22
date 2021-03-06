using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSŠMobil
{
    class Kupec
    {
        protected string ime;
        protected decimal stanje;

        public string Ime { get => ime; set => ime = value;}
        public decimal Stanje { get => stanje;}//read only

        public void beleziPlacilo(decimal placano)
        {
            stanje -= placano;
        }
        public virtual void beleziKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1://stacionarno
                    stanje += minute * 0.2m;
                    break;
                case 2://mobilno
                    stanje += minute * 0.03m;
                    break;
            }
        }
        public override string ToString()
        {
            return Ime + " dolguje " + Stanje;
        }
    }
}
