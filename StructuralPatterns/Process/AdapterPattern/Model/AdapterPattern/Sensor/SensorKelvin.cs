namespace StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Sensor
{
    internal class SensorKelvin
    {
        public string? APIRoute { get; set; }

        public SensorKelvin() { }

        public double GetTemperatureInKelvin()
        {
            return 298.65;
        }
    }
}
