namespace StructuralPatterns.Process.CompositePattern.Model
{
    public class Menu : IMenuComponent
    {
        public List<IMenuComponent> MenuItems { get; set; } = new List<IMenuComponent>();

        public void Add(IMenuComponent menuComponent)
        {
            MenuItems.Add(menuComponent);
        }

        public void Display()
        {
            Console.WriteLine("\nMenu:");
            foreach (var item in MenuItems)
            {
                item.Display();
            }
        }
    }
}
