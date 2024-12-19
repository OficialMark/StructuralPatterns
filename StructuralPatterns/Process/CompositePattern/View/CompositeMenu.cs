using StructuralPatterns.Process.CompositePattern.Model;

namespace StructuralPatterns.Process.CompositePattern.View
{
    public class CompositeMenu
    {
        public static int Show(IMenuComponent menu)
        {
            Console.WriteLine("\nComposite Pattern:");
            Console.WriteLine("1.Add item in menu");
            Console.WriteLine("2.Display menu");
            Console.WriteLine("3.Exit");

            var option = Console.ReadLine();
            var op= int.TryParse(option, out var result) ? result : 3;

            return op;
        }

        public static void AddItem(IMenuComponent menu)
        {
            Console.WriteLine("Enter the name of the item:");
            var name = Console.ReadLine();
            var menuItem = new MenuComponent { Name = name };
            menu.Add(menuItem);
        }

        public static void DisplayMenu(IMenuComponent menu)
        {
            menu.Display();
        }
    }
}
