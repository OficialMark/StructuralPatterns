namespace StructuralPatterns.Process.AdapterPattern.View.AdapterPattern
{
    public static class MenuAdapter
    {
        public static string Show()
        {
            Console.Clear();
            Console.WriteLine("Adapter Pattern\n");
            Console.WriteLine("1. Read temperature in Celsius");
            Console.WriteLine("2. Read temperature in Fahrenheit");
            Console.WriteLine("3. Read temperature in Kelvin");
            Console.WriteLine("4. Back");
            Console.Write("\nSelect an option: ");
            int op = Convert.ToInt32(Console.ReadLine());

            var opcoes = (List<string>)["Celsius", "Fahrenheit", "Kelvin"];
            return opcoes[op - 1];
        }
    }
}
