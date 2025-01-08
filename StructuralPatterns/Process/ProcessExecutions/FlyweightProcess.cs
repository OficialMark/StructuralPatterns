using StructuralPatterns.Process.FlyweightPattern.Model;

namespace StructuralPatterns.Process.ProcessExecutions
{
    public class FlyweightProcess
    {
        public static void Execute()
        {
            var treeFactory = new TreeFactory();

            var oakTree = treeFactory.GetTreeType("Oak", "Green", "Rough");
            var pineTree = treeFactory.GetTreeType("Pine", "Green", "Smooth");

            var forest = new List<Tree>
            {
                new Tree(oakTree, 1, 2),
                new Tree(oakTree, 3, 4),
                new Tree(pineTree, 5, 6),
                new Tree(pineTree, 7, 8)
            };


            Console.WriteLine("Flywheigt Pattern: storing shared attributes in a TreeType Class");
            foreach (var tree in forest)
            {
                Console.WriteLine($"Tree: {tree.Type.Name}, {tree.Type.Color}, {tree.Type.Texture}, X: {tree.X}, Y: {tree.Y}");
            }
        }
    }
}
