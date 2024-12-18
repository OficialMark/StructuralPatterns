using StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Adapter.Interface;

namespace StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Adapter
{
    public class CelsiusAdapter : ITemperatureCensor
    {
        public CelsiusAdapter() { }

        public double ReadTemperature()
        {
            var Sensor = new Sensor.SensorCelsius();
            return Sensor.GetTemperatureInCelsius();
        }
    }
}
