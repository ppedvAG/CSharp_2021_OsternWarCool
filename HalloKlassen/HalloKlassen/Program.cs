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
