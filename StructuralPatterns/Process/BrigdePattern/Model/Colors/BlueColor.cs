using System.Drawing;

namespace StructuralPatterns.Process.BrigdePattern.Model.Colors
{
    public class BlueColor : IColor
    {
        public void Paint()
        {
            Console.WriteLine($"painting the shape with the color blue");
        }
    }
}
