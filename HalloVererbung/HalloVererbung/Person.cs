using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloVererbung
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime GebDatum { get; set; }
        public string Anschrift { get; set; }

        public int CalcAge()
        {
            return -1;//todo
        }
    }

    public class Arzt : Person
    {
        public string Fachrichtung { get; set; }
        public int ArztNummer { get; set; }
    }

    public class Mitarbeiter : Person
    {
        public DateTime Einstellungsdatum { get; set; }
        public string Job { get; set; }
    }

    public class Patient : Person
    {
        public int Patientennummer { get; set; }
        public string Diagnose { get; set; }
        public Arzt Arzt { get; set; }

    }
}
