using StructuralPatterns.Process.BrigdePattern.Model.Colors;

namespace StructuralPatterns.Process.BrigdePattern.Model.Shapes
{
    public class CircleShape : IShape
    {
        public IColor Color { get; set; }

        public CircleShape(IColor color)
        {
            Color = color;
        }

        public void Draw()
        {
            Console.Write($"Drawing a circle ");
            if (Color != null)
            {
                Color.Paint();
            }
        }
    }
}
