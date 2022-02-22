using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    internal class Helikopter : MozgoJarmu
    {
        float sebesseg = 1.0f;

        public Helikopter(Terkep terkep, float x, float y) : base('H',terkep,x,y)
        {

        }

        public void Gyorsit()
        {
            sebesseg += 0.1f;
        }

        public void Lassit()
        {
            sebesseg = Math.Max(sebesseg - 0.1f, 0.0f);
        }

        public override void Mozog()
        {
            if (IdeLephet(x + IranyX * sebesseg, y + IranyY * sebesseg))
            {
                x += IranyX * sebesseg;
                y += IranyY * sebesseg;
            }
        }


    }
}
