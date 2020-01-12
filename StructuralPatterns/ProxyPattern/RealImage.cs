using System;

namespace ProxyPattern
{
    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk(fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine($"Loading { fileName}");
        }
        public void Display()
        {
            Console.WriteLine($"Displaying{ _fileName}");
        }
    }
}
