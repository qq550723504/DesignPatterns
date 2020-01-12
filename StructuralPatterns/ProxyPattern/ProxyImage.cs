namespace ProxyPattern
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private readonly string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public virtual void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(_fileName);
            }
            realImage.Display();
        }
    }
}
