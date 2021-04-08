using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    public class Auto
    {
        public string Besitzer { get; set; } //AutoProperty
        public string Hersteller { get; set; } //AutoProperty


        private string modell; //backing field
        public string Modell //das FullProperty
        {
            get { return modell; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Biste doof? Der String ist leer");

                modell = value;
            }
        }

        private int PS; //manual. getter und setter (macht man nicht, dafür gibts properties)

        public int GetPS() //getter
        {
            return PS;
        }

        public void SetPS(int ps) //setter
        {
            if (ps < 0)
                Console.WriteLine("Biste doof? Neative PS.");

            PS = ps;
        }

        //internal string farbe;
        public string Farbe { get; private set; }


        private bool innenBeleuchtung;//false  

        public void Hupen()
        {
            Console.Beep(1000 - PS, 200);

            innenBeleuchtung = !innenBeleuchtung;
        }

        public Auto(string farbe)
        {
            Console.WriteLine("Ein tolles neues Auto");
            PS = 100;
            this.Farbe = farbe;
        }

        public Auto() //default constructor
        {
            Console.WriteLine("Ein tolles neues Auto");

            PS = 50;
            Farbe = "pink";
        }

        ~Auto() //destruktor
        {
            Console.WriteLine("Bye Bye");
        }

    }
}
