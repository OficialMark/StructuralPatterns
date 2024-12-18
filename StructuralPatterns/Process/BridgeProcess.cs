using StructuralPatterns.Process.BrigdePattern.Controller;
using StructuralPatterns.Process.BrigdePattern.View;

namespace StructuralPatterns.Process
{
    internal class BridgeProcess
    {
        public static void Execute()
        {
            Console.WriteLine("Bridge Pattern Process\n");
            var options = MenuBridge.Show();

            while (options.Count == 2)
            {
                ControllerBridge.BridgeOperation(options);
                options = MenuBridge.Show();
            }
        }
    }
}
