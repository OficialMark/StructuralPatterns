namespace StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Sensor
{
    public class SensorCelsius
    {
        public string? APIRoute { get; set; }

        public SensorCelsius() { }

        public double GetTemperatureInCelsius()
        {
            return 25.5;
        }
    }
}
