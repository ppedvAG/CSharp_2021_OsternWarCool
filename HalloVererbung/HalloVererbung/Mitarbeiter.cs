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
    }
}
