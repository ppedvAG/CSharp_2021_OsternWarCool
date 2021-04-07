using System;

namespace HalloKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SagHallo();
            string derName = "Wilma";
            SagHallo(derName, 76);

            int zahl = GibMirFünf();
            Console.WriteLine(zahl);
            int dasDoppelte = Verdoppeln(Verdoppeln(Verdoppeln(Verdoppeln(Verdoppeln(zahl)))));
            Console.WriteLine(dasDoppelte);

            Auto meinAuto; //deklaration
            meinAuto = new Auto(); //instanzierung

            Auto meinAuto2 = new Auto(); //deklaration + instanzierung

            meinAuto.Farbe = "blau";
            meinAuto.Hersteller = "Baudi";
            meinAuto.Modell = "g9";
            meinAuto.PS = 873;

            meinAuto2.Farbe  = "gelb";
            meinAuto2.Hersteller = "Bercedes";
            meinAuto2.Modell = "m99";
            meinAuto2.PS = 200;
            

            ZeigeAuto(meinAuto);
            ZeigeAuto(meinAuto2);

            meinAuto.Hupen();
            meinAuto2.Hupen();
        }

        static void ZeigeAuto(Auto einAuto)
        {
            Console.WriteLine($"{einAuto.Hersteller} {einAuto.Modell} {einAuto.Farbe} {einAuto.PS}PS");
        }

        static void SagHallo() //einfache Methode (überladen)
        {
            Console.WriteLine("Hallo");
        }
        static void SagHallo(string name, int alter) //methode mit Parameter (überladen)
        {
            Console.WriteLine($"Hallo {name} {alter}");
        }

        static int GibMirFünf()
        {
            return 5;
        }
        static int Verdoppeln(int zahl)
        {
            return zahl * 2;
        }


    }
}
