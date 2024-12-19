namespace StructuralPatterns.Process.CompositePattern.Model
{
    public class MenuComponent : IMenuComponent
    {
        public string? Name { get; set; }

        public void Add(IMenuComponent menuComponent)
        {
            Console.WriteLine("It's not possible add a component in a leaf");
        }

        public void Display()
        {
            Console.WriteLine("Menu Item: " + Name);
        }
    }
}
