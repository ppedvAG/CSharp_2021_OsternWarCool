using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    internal class Auto
    {
        public string Hersteller;
        public string Modell;
        public int PS;
        internal string Farbe;

        private bool innenBeleuchtung ;//false  

        public void Hupen()
        {
            Console.Beep(1000 - PS, 200);

            innenBeleuchtung = !innenBeleuchtung;
        }
    }
}
