using System;
using System.IO;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Hello World!");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Hello World in Cyan");

            int zahl = 43587;
            Console.WriteLine(zahl);

            double kommaZahl = 345.345341432432443287;
            Console.WriteLine(kommaZahl);

            decimal gehalt = 100000.0000m;
            Console.WriteLine(gehalt);

            char buchßtabe = 'b';
            string täext = "🍟🌭🍕🍔";

            Console.WriteLine(täext);

            bool jaOderNein = true;

            var einDing = 45m;
            einDing = 346m;

            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Geld: " + gehalt + "€");

            Console.WriteLine("Geld: {0:c} ({1:#.00})", gehalt, kommaZahl);
            Console.WriteLine($"Geld: {gehalt:c} € ({kommaZahl:#.00})"); //"neu" ab 2015

            Console.WriteLine("Bitte eine Zahl eingeben");
            string eingabe = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Die Eingabe war: {eingabe}");

            try
            {
                int eingabeAlsInt = int.Parse(eingabe);
                Console.WriteLine($"Das doppelte ist: {eingabeAlsInt * 2}");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Kauf mehr Speicher!");
            }
            catch (Exception)
            {
                Console.WriteLine("Das war dumm!");
            }

            if (int.TryParse(eingabe, out int eingabeAlsIntTryParse))
            {
                Console.WriteLine($"Das doppelte ist: {eingabeAlsIntTryParse * 2}");
            }
            else
            {
                Console.WriteLine("Das war dumm!");
            }


            kommaZahl = zahl; //implizit, weil double größer als int ist 

            zahl = (int)kommaZahl; //casting: muss explizit wegen datenverlust


            bool istWahr = true;
            bool istFalsch = false;

            bool oder = istWahr || istFalsch;
            bool oder2 = true || false;
            bool oder3 = 14 > 7 || System.IO.File.Exists("b:\\owehfkefw.txt");

            bool und = true && false;

            bool und2 = args != null && args[1].Length > 9;


        }
    }
}
