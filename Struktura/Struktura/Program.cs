using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktura
{
    class Program
    {
        struct vektor
        {
            public double x, y, z;
            public double this[int i]
            {
                get {switch (i) {
                        case 0:
                            return x;
                        case 1:
                            return y;
                        case 2:
                            return z;
                        default:
                            throw new IndexOutOfRangeException("Napačen indeks");
                    }
                    }
                set { switch (i) {
                        case 0:
                            x = value; break;
                        case 1:
                            y = value; break;
                        case 2:
                            z = value; break;
                        default:
                            throw new IndexOutOfRangeException("Napačen indeks");
                    }
                }
            }
            public override string ToString()
            {
                return "(" + x + ", " + y + ", " + z + ")";
            }
            public vektor(double x1, double y1, double z1)
            {
                x = x1;y = y1;z = z1;
            }
            public vektor(vektor v)
            {
                x = v.x;y = v.y;z = v.z;
            }
            public static vektor operator +(vektor levi, vektor desni)
            {
                vektor r;
                r.x = levi.x + desni.x;
                r.y = levi.y + desni.y;
                r.z = levi.z + desni.z;
                return r;
            }
            public static vektor operator * (double levi, vektor desni)
            {
                vektor r;
                r.x = levi * desni.x;
                r.y = levi * desni.y;
                r.z = levi * desni.z;
                return r;
            }
            public static vektor operator * (vektor levi, double desni)
            {
                return desni * levi;
            }
            public static double operator * (vektor v, vektor w)
            {
                return v.x * w.x + v.y * w.y + v.z * w.z;
            }
            public static bool operator ==(vektor v, vektor w)
            {
                return v.x == w.x && v.y == w.y && v.z == w.z;
            }
            public static bool operator !=(vektor v, vektor w)
            {
                return !(v == w);
            }

        }
        static void Main(string[] args)
        {
            vektor v1;
            v1.x = 1;
            v1.y = 1;
            v1.z = 1;
            Console.WriteLine(v1.ToString());
            vektor v2 = new vektor(2,-1,2);
            Console.WriteLine(v2.ToString());
            vektor v3 = v1 + v2;
            Console.WriteLine(v3.ToString());
            Console.WriteLine((7*v1).ToString());
            Console.WriteLine((v1*v2).ToString());
            Console.WriteLine("V1==V2? "+(v1==v2));

            for (int k = 0; k < 3; k++)
            {
                v1[k] = 2 * k;
            }
            Console.WriteLine(v1.ToString());
            Console.ReadLine();

        }
    }
}
