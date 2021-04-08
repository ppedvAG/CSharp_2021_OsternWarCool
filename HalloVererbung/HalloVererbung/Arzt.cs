namespace HalloVererbung
{

    public enum Fachrichtung
    {
        Allgemeinmedizin,
        Anästhesiologie = 12,
        Anatomie,
        Arbeitsmedizin,
        Augenheilkunde = 69,
        Biochemie,
        Chirurgie
        /*..*/
    }

    public class Arzt : Person
    {
        public Fachrichtung Fachrichtung { get; set; }
        public int ArztNummer { get; set; }

        public override int CalcAge()
        {
            var orgAge = base.CalcAge();
            return orgAge - 5;
            //return 29;
        }

        public Arzt(string name) : base(name)
        {
        }
    }
}
