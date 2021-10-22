using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravokotnik
{
    class Pravokotnik
    {
        private double širina;
        private double višina;
        private double ploščina;

        public double Širina { get => širina; set => širina = value; }
        public double Višina { get => višina; set => višina = value; }
        public double Ploščina { get => višina*širina;}

        public Pravokotnik()
        {
            širina = 0;
            višina = 0;
        }
        public Pravokotnik(double Š, double V)
        {
            širina = Š;
            višina = V;
        }
    public static bool operator ==(Pravokotnik p1, Pravokotnik p2)
        {
            if(p1.ploščina == p2.ploščina)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    public static bool operator !=(Pravokotnik p1, Pravokotnik p2)
        {
            if (p1 == p2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    public static bool operator >(Pravokotnik p1, Pravokotnik p2)
        {
            if (p1.ploščina > p2.ploščina)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator <(Pravokotnik p1, Pravokotnik p2)
        {
            if (p1 < p2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator <=(Pravokotnik p1, Pravokotnik p2)
        {
            if (p1 <= p2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >=(Pravokotnik p1, Pravokotnik p2)
        {
            if (p1 >= p2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
