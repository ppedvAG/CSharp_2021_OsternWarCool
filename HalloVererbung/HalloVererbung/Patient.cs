using System;

namespace HalloVererbung
{
    public class Patient : Person
    {
        public int Patientennummer { get; set; }
        public string Diagnose { get; set; }
        public Arzt Arzt { get; set; }

        public override string ToString()
        {
            return $"Patient {Name} #{Patientennummer:000}";
        }

        public override void Hupen()
        {
            Console.WriteLine("Ein Patient der hupt");
            Console.Beep(500, 200);
            Console.Beep(400, 200);
        }

        public Patient() : this("***Anonym***")
        {
           
        }

        public Patient(string name) : base(name)
        {

        }

    }
}
