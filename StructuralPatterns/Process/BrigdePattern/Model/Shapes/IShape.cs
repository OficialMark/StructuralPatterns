using StructuralPatterns.Process.BrigdePattern.Model.Colors;

namespace StructuralPatterns.Process.BrigdePattern.Model.Shapes
{
    public interface IShape
    {
        public IColor Color { get; set; }

        public void Draw()
        {
            if (Color != null)
            {
                Color.Paint();
            };
        }
    }
}
