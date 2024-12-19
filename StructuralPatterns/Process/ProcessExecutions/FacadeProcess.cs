using StructuralPatterns.Process.Facade.View;

namespace StructuralPatterns.Process.ProcessExecutions
{
    public class FacadeProcess
    {
        public static void Execute()
        {
            FacadeMenu.Show();
            CompositeProcess.Execute();
        }
    }
}
