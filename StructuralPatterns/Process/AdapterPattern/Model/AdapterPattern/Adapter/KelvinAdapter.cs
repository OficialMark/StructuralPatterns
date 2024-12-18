namespace StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Adapter
{
    public class KelvinAdapter
    {
        public KelvinAdapter() { }

        public double ReadTemperature()
        {
            var Sensor = new Sensor.SensorKelvin();
            return Sensor.GetTemperatureInKelvin();
        }
    }
}
