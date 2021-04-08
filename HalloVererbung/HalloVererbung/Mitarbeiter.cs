using System;

namespace HalloVererbung
{
    public class Mitarbeiter : Person
    {
        public DateTime Einstellungsdatum { get; set; }
        public string Job { get; set; }

        public Mitarbeiter(string name, DateTime einstellDatum) : base(name)
        {
            Einstellungsdatum = einstellDatum;
        }

        public override void Hupen()
        {
            Console.WriteLine("Ein Mitarbeiter der hupt");
            Console.Beep(400, 200);
            Console.Beep(500, 200);
        }
    }
}
