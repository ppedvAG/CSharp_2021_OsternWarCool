namespace HalloVererbung
{
    public class Arzt : Person
    {
        public string Fachrichtung { get; set; }
        public int ArztNummer { get; set; }

        public Arzt(string name) : base(name)
        {
        }
    }
}
