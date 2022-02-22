using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    internal class TerkepEsJarmuRajzolo : TerkepRajzolo
    {
        protected Jarmu[] jarmuvek;
        protected int jarmuvekN;

        public TerkepEsJarmuRajzolo(Terkep terkep, int jarmuvekszama) : base(terkep)
        {
            jarmuvek = new Jarmu[jarmuvekszama];
            jarmuvekN = 0;
        }

        public void jarmufelvetel(Jarmu jarmu)
        {
            jarmuvek[jarmuvekN] = jarmu;
            jarmuvekN++;
        }

        protected override char MiVanItt(int x, int y)
        {
            int i = 0;
            while (i < jarmuvekN && ((int)jarmuvek[i].X != x || (int)jarmuvek[i].Y != y))
            {
                i++;
            }
            return i < jarmuvekN ? jarmuvek[i].Azonosito : base.MiVanItt(x, y);
        }

    }
}
