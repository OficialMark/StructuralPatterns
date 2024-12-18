using StructuralPatterns.Process.BrigdePattern.Model.Colors;
using System.Drawing;

namespace StructuralPatterns.Process.BrigdePattern.Model.Shapes
{
    public class SquareShape : IShape
    {
        public IColor Color { get; set; }

        public SquareShape(IColor color)
        {
            Color = color;
        }

        public void Draw()
        {
            Console.Write($"Drawing a square ");
            if (Color != null)
            {
                Color.Paint();
            }
            Console.WriteLine("");
        }
    }
}
