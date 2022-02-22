using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Jarmu
    {
        private char azonosito;
        protected float x, y;
        protected Terkep terkep;

        public Jarmu(char azonosito, float x, float y, Terkep terkep)
        {
            this.azonosito = azonosito;
            this.x = x;
            this.y = y;
            this.terkep = terkep;
        }

        public char Azonosito { get => azonosito; }
        public float X { get => x; }
        public float Y { get => y; }

        public virtual bool IdeLephet(float x, float y)
        {
            return terkep.TerkepenBeluliPozicio(x, y);
        }

    }
}
