namespace HalloCam.Model
{
    public class Kamera : Teil
    {
        public string SensorTyp { get; set; }
        public double Sensoregröße { get; set; }
        public Anschlusstyp Anschlusstyp { get; set; }
    }
}
