using StructuralPatterns.Process.AdapterPattern.Controller.AdapterPattern;
using StructuralPatterns.Process.AdapterPattern.View.AdapterPattern;

namespace StructuralPatterns.Process.Executions
{
    public static class AdapterProcess
    {
        public static void Execute()
        {
            string option = MenuAdapter.Show();
            while (option == "Celsius" || option == "Celsius" || option == "Fahrenheit" || option == "Kelvin")
            {
                AdapterController.ReadWithSensor(option);
                Console.Write("\nPress any key to continue...");
                Console.ReadKey();

                option = MenuAdapter.Show();
            }
        }
    }
}
