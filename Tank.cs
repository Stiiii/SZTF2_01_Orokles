using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    sealed class Tank : Auto
    {
        float uzemanyag;

        public Tank(char azonosito, Terkep terkep, float x, float y, float uzemanyag) : base(azonosito, terkep, x, y)
        {
            this.uzemanyag = uzemanyag;
        }

        public override bool IdeLephet(float x, float y)
        {
            if (x + IranyX < terkep.MeretX && y + IranyY < terkep.MeretY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Mozog()
        {
            if (IdeLephet(x,y) && uzemanyag >= 0.1f)
            {
                x += IranyX;
                y += IranyY;
                uzemanyag += -0.1f;
            }
        }
    }
}
