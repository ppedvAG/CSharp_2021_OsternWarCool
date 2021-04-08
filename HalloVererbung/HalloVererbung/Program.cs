using System;

namespace HalloVererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person("Peter") { GebDatum = new DateTime(1990, 8, 15) };

            Arzt a = new Arzt("Anton");
            a.ArztNummer = 1;
            a.Fachrichtung = "Allgemein";
            a.GebDatum = new DateTime(1974, 1, 29);

            Mitarbeiter m = new Mitarbeiter("Marta", DateTime.Now.AddDays(-302));
            m.Job = "Rezeption";
            m.GebDatum = new DateTime(2002, 4, 4);

            Patient pat = new Patient();
            pat.Name = "Paula";
            pat.Diagnose = "Q18.3 Flügelfell des Halses";
            pat.Arzt = a;
            pat.GebDatum = new DateTime(2005, 12, 14);
            
            ShowPerson(p);
            ShowPatient(pat);

            ShowPerson(a); //impliziter downcast
            ShowPerson(m);
            ShowPerson(pat);

            Show(pat);
            Show(17);
            Show(new ApplicationException());

            Console.WriteLine(pat.ToString());
        }

        static void Show(Object o)
        {
            if (o is Patient p)
                Console.WriteLine(p.Name);
        }

        static void ShowPerson(Person person)
        {
            Console.WriteLine($"Person: {person.Name} geboren am {person.GebDatum:d} [{person.CalcAge()}] aus {person.Anschrift}");

            //1. prüfen und casten [old style vor 2005] 👎
            if (person is Arzt) //typprüfung
            {
                Arzt personAlsArzt = (Arzt)person; //casting
                Console.WriteLine("\tDas ist ein Arzt [casting]");
            }

            //2. Boxing [ab 2005 (.NET 2.0)] 😐
            Arzt personAlsArztBoxing = person as Arzt;
            if (personAlsArztBoxing != null)
            {
                Console.WriteLine("\tDas ist ein Arzt [boxing]");
            }

            //3. pattern matching (C# 7.0 ab 2016) - cool 👍
            if (person is Arzt personAlsArztPM)
            {
                Console.WriteLine($"\tDas ist ein Arzt [pattern-matching] [{personAlsArztPM.CalcAge()}]");
            }
        }

        static void ShowPatient(Patient patient)
        {
            if (patient.Arzt != null)
                Console.WriteLine($"Patient: {patient.Name} mit '{patient.Diagnose}' von Arzt {patient.Arzt.Name}");
            else
                Console.WriteLine($"Patient: {patient.Name} mit '{patient.Diagnose}' ohne Arzt");
        }
    }
}
