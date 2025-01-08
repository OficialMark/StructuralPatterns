namespace StructuralPatterns.Process.FlyweightPattern.Model
{
    public class Tree
    {
        public TreeType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Tree(TreeType type, int x, int y)
        {
            Type = type;
            X = x;
            Y = y;
        }
    }
}
