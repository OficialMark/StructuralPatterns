using System.Collections;

namespace StructuralPatterns.Process.FlyweightPattern.Model
{
    public class TreeFactory
    {
        public ICollection<TreeType> Trees { get; set; } = [];

        public TreeType GetTreeType(string name, string color, string texture)
        {
            var treeType = Trees.FirstOrDefault(t => t.Name == name && t.Color == color && t.Texture == texture);

            if (treeType == null)
            {
                treeType = new TreeType { Name = name, Color = color, Texture = texture };
                Trees.Add(treeType);
            }

            return treeType;
        }
    }
}
