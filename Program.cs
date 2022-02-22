using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Teszt1()
        {
            Terkep terkep = new Terkep(80, 25);
            TerkepRajzolo rajzolo = new TerkepRajzolo(terkep);
            rajzolo.Kirajzol();
        }

        static void teszt2()
        {
            Terkep terkep = new Terkep(80, 25);
            TerkepEsJarmuRajzolo rajozolos = new TerkepEsJarmuRajzolo(terkep, 100);
            Jarmu jarmu = new Jarmu('*', 10, 10, terkep);
            rajozolos.jarmufelvetel(jarmu);
            rajozolos.Kirajzol();
        }

        static void teszt3()
        {
            Terkep terkep = new Terkep(80, 25);
            Szimulacio szim = new Szimulacio(terkep, 10);
            Helikopter h = new Helikopter(terkep, 5, 5);

            szim.jarmufelvetel(h);
            h.UjIranyVektor(1, 0);
            szim.Fut();
        }

        static void teszt4()
        {
            Terkep terkep = new Terkep(80, 25);
            Szimulacio szim = new Szimulacio(terkep, 10);
            Helikopter h = new Helikopter(terkep, 5, 5);
            Auto a = new Auto('A', terkep, 7, 1);

            szim.jarmufelvetel(a);
            a.UjIranyVektor(1, 0);

            szim.jarmufelvetel(h);
            h.UjIranyVektor(1, 0);
            szim.Fut();

        }

        static void teszt5()
        {
            Terkep terkep = new Terkep(80, 25);
            Szimulacio szim = new Szimulacio(terkep, 10);
            Tank t = new Tank('T', terkep, 10, 10, 0.5f);

            szim.jarmufelvetel(t);
            t.UjIranyVektor(1, 0);
            szim.Fut();
        }

        static void UtolsoTeszt()
        {
            Terkep terkep = new Terkep(80, 25);
            Szimulacio szim = new Szimulacio(terkep, 10);

            Helikopter h = new Helikopter(terkep, 15, 15);
            h.UjIranyVektor(1, 1);
            szim.jarmufelvetel(h);
            Tank t = new Tank('T', terkep, 10, 10, 1f);
            t.UjIranyVektor(1, -1);
            szim.jarmufelvetel(t);
            Auto a = new Auto('A', terkep, 1, 13);
            a.UjIranyVektor(1, 0);
            szim.jarmufelvetel(a);

            szim.Fut();
        }

        static void Main(string[] args)
        {
            //Teszt1();
            //teszt2();
            //teszt3();
            //teszt4();
            //teszt5();
            UtolsoTeszt();
        }
    }
}
