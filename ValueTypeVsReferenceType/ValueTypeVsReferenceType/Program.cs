using System;
using System.Collections.Generic;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int zahl = 16;
            Verdoppeln(zahl);
            Console.WriteLine(zahl);

            decimal geld = 9843597843598m;

            Auto meinAuto = null;
            meinAuto = new Auto();
            meinAuto.Farbe = "gelb";

            Auto deinAuto = meinAuto;
            deinAuto.Farbe = "rot";

            MachAutoBlau(meinAuto);

            //var list = new List<Auto>();
            //while (true)
            //    list.Add(new Auto());

            if (meinAuto != null)
                meinAuto.PS = 16;


        }

        private static void Verdoppeln(int zahl)
        {
            zahl = zahl * 2;
            //Verdoppeln(zahl);
        }

        private static void MachAutoBlau(Auto einAuto)
        {
            einAuto.Farbe = "blau";
        }


    }


    class Auto
    {
        public int PS { get; set; }
        public string Farbe { get; set; }
    }
}
