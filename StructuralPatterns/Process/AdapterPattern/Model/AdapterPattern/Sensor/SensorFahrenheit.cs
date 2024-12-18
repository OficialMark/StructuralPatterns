namespace StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Sensor
{
    public class SensorFahrenheit
    {
        public string? APIRoute { get; set; }

        public SensorFahrenheit() { }

        public double GetTemperatureInFahrenheit()
        {
            return 77.9;
        }
    }
}
