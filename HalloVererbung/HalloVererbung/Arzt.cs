namespace HalloVererbung
{
    public class Arzt : Person
    {
        public string Fachrichtung { get; set; }
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
