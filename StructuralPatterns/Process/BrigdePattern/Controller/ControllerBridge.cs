using StructuralPatterns.Process.BrigdePattern.Model.Colors;
using StructuralPatterns.Process.BrigdePattern.Model.Shapes;

namespace StructuralPatterns.Process.BrigdePattern.Controller;

public class ControllerBridge
{
    public static void BridgeOperation(List<String> options)
    {
        IShape? form = null;
        IColor? color = null;

        if (options[1] != null && options[0] != null)
        {
            switch (options[0])
            {
                case "Red":
                    color = new RedColor();
                    break;
                case "Blue":
                    color = new BlueColor();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            switch (options[1])
            {
                case "Square":
                    form = new SquareShape(color);
                    break;

                case "Circle":
                    form = new CircleShape(color);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }

        if (form != null)
        {
            form.Draw();
        }
    }
}
