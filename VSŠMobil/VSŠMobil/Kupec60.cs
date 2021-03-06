using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSŠMobil
{
    class Kupec60:Kupec
    {
        private int visjaTarifaPorabljeno;//koliko od 60min je ze porabljenih
        public override void beleziKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1:
                    stanje += minute * 0.2m;
                    break;
                case 2:
                    int vMinute, nMinute;
                    int šeVMinute = (visjaTarifaPorabljeno < 60) ? 60 - visjaTarifaPorabljeno : 0;
                    if (minute > šeVMinute)
                    {
                        vMinute = šeVMinute;
                        nMinute = minute - vMinute;

                    }
                    else
                    {
                        vMinute = minute;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.05m + nMinute * 0.01m;
                    visjaTarifaPorabljeno += vMinute;
                    break;
            }
        }
    }
}
