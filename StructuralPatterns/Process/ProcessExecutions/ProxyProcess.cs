using StructuralPatterns.Process.ProxyPattern;

namespace StructuralPatterns.Process.ProcessExecutions
{
    public class ProxyProcess
    {
        public static void Execute()
        {
            Console.WriteLine("Proxy Pattern: \n");

            IImage image1 = new ImageProxy("High-resolution-image-1.jpg");
            IImage image2 = new ImageProxy("High-resolution-image-2.jpg");

            Console.WriteLine("At this moment, the images are not loaded yet");

            image1.Display();
            image2.Display();
        }
    }
}
