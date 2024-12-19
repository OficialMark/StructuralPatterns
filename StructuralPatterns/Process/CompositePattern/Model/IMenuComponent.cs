namespace StructuralPatterns.Process.CompositePattern.Model
{
    public interface IMenuComponent
    {
        public void Add(IMenuComponent menuComponent);
        public void Display();
    }
}
