﻿namespace HalloVererbung
{
    public class Patient : Person
    {
        public int Patientennummer { get; set; }
        public string Diagnose { get; set; }
        public Arzt Arzt { get; set; }

        public Patient() : this("***Anonym***")
        {

        }

        public Patient(string name) : base(name)
        {

        }

    }
}
