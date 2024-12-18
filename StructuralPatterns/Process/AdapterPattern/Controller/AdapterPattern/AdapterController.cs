using StructuralPatterns.Process.AdapterPattern.Model.AdapterPattern.Adapter;

namespace StructuralPatterns.Process.AdapterPattern.Controller.AdapterPattern
{
    public class AdapterController
    {
        public static void ReadWithSensor(string sensorType)
        {
            switch (sensorType)
            {
                case "Kelvin":
                    {
                        var adapter = new KelvinAdapter();
                        var temperature = adapter.ReadTemperature();
                        Console.WriteLine($"Temperature in Kelvin: {temperature}");
                        break;
                    }

                case "Celsius":
                    {
                        var adapter = new CelsiusAdapter();
                        var temperature = adapter.ReadTemperature();
                        Console.WriteLine($"Temperature in Kelvin: {temperature}");
                        break;
                    }

                case "Fahrenheit":
                    {
                        var adapter = new FahrenheitAdapter();
                        var temperature = adapter.ReadTemperature();
                        Console.WriteLine($"Temperature in Kelvin: {temperature}");
                        break;
                    }
            }
        }
    }
}
