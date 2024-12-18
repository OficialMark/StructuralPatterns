using StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Adapter.Interface;

namespace StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Adapter
{
    public class FahrenheitAdapter : ITemperatureCensor
    {
        public FahrenheitAdapter() { }

        public double ReadTemperature()
        {
            var Sensor = new Sensor.SensorFahrenheit();
            return Sensor.GetTemperatureInFahrenheit();
        }
    }
}
