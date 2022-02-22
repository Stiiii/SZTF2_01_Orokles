using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    internal class Szimulacio : TerkepEsJarmuRajzolo
    {
        public Szimulacio(Terkep terkep, int jarmuvekszama) : base(terkep, jarmuvekszama)
        {
        }

        public void Fut()
        {
            while (true)
            {
                EgyIdoEgysegEltelt();
                Kirajzol();
                System.Threading.Thread.Sleep(500); 
            }
        }

        public void EgyIdoEgysegEltelt()
        {
            for (int i = 0; i < jarmuvekN; i++)
            {
                if (jarmuvek[i] is MozgoJarmu)
                {
                    (jarmuvek[i] as MozgoJarmu).Mozog();
                }
            }
        }



    }
}
