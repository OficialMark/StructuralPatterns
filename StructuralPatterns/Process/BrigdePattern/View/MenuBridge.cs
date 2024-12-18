namespace StructuralPatterns.Process.BrigdePattern.View
{
    public class MenuBridge
    {
        public static List<String> Show()
        {
            var options = new List<String>();

            Console.WriteLine("Choose a color:");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");

            var colors = new List<String> { "Red", "Blue" };

            string item = colors[int.Parse(Console.ReadLine())-1];
            options.Add(item);


            Console.WriteLine("Choose a shape:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Circle");

            var shapes = new List<String> { "Square", "Circle" };

            item = shapes[int.Parse(Console.ReadLine())-1];
            options.Add(item);

            return options;
        }            
    }
}
