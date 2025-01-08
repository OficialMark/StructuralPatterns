namespace StructuralPatterns.Process.ProxyPattern
{
    public class ImageProxy : IImage
    {
        private IImage _realImage;

        public ImageProxy(string fileName)
        {
            _realImage = new RealImage(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Simulating a verification or necessary process until the real image is displayed");
            Console.WriteLine("Displaying proxy image: ");

            _realImage.Display();
        }
    }
}
