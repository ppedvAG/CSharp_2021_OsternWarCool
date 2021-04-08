using System;

namespace HalloVererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Person p = new Person() { Name = "Peter" };

            Arzt a = new Arzt();
            a.Name = "Anton";
            a.ArztNummer = 1;
            a.Fachrichtung = "Allgemein";

            Mitarbeiter m = new Mitarbeiter();
            m.Name = "Marta";
            m.Einstellungsdatum = DateTime.Now.AddDays(-302);
            m.Job = "Rezeption";

            Patient pat = new Patient();
            pat.Name = "Paula";
            pat.Diagnose = "Q18.3 Flügelfell des Halses";
            pat.Arzt = a;

        }
    }
}
