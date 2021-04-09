using System;

namespace HalloVererbung
{
    public class Patient : Person, IKündbar
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

        private bool isGekündigt;
        public bool IsGekündigt
        {
            get { return isGekündigt; }
            set { isGekündigt = value; }
        }

        public void Kündigen()
        {
            if(isGekündigt)
                Console.WriteLine("Der Patient wurde bereits gekündigt");
            else 
            {
                IsGekündigt = true;
                Console.WriteLine($"Der Patient {Name} wurde gekündigt");
            }
        }

        public Patient() : this("***Anonym***")
        {

        }

        public Patient(string name) : base(name)
        {

        }

    }
}
