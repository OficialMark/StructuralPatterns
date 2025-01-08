namespace StructuralPatterns.Process.ProxyPattern
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_fileName}\n");
        }
    }
}
