using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    internal class Auto : MozgoJarmu
    {
        protected float sebesseg = 1.0f ;
        public Auto(char azonosito, Terkep terkep, float x, float y) : base(azonosito, terkep, x, y)
        {

        }

        public override bool IdeLephet(float x, float y)
        {
            return terkep.Magassag(x, y) > 0 ? true : false;
        }

        public override void Mozog()
        {
            if (IdeLephet(x + IranyX * sebesseg, y + IranyY * sebesseg))
            {
                if (terkep.Magassag(x, y) > terkep.Magassag(x + IranyX, y + IranyY))
                {
                    Gyorsit();
                    if (x + IranyX * sebesseg < terkep.MeretX && y + IranyY * sebesseg < terkep.MeretY)
                    {
                        x += IranyX * sebesseg;
                        y += IranyY * sebesseg;
                    }
                }
                else if (terkep.Magassag(x, y) < terkep.Magassag(x + IranyX, y + IranyY))
                {
                    Lassit();

                    if (x + IranyX * sebesseg < terkep.MeretX && y + IranyY * sebesseg < terkep.MeretY)
                    {
                        x += IranyX * sebesseg;
                        y += IranyY * sebesseg;
                    }
                }
                else
                {
                    if (x + IranyX * sebesseg < terkep.MeretX && y + IranyY * sebesseg < terkep.MeretY)
                    {
                        x += IranyX * sebesseg;
                        y += IranyY * sebesseg;
                    }
                }
            }
        }

        public void Gyorsit()
        {
            sebesseg += 0.1f;
        }

        public void Lassit()
        {
            sebesseg = Math.Max(sebesseg - 0.1f, 0.0f);
        }
    }
}
