using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    abstract class MozgoJarmu : Jarmu
    {
        protected float IranyX;
        protected float IranyY;


        public void UjIranyVektor(float iranyX, float iranyY)
        {
            this.IranyX = iranyX;
            this.IranyY = iranyY;
        }

        public MozgoJarmu(char azonosito, Terkep terkep, float x, float y) : base(azonosito, x, y, terkep)
        {

        }

        public abstract void Mozog();

    }
}
