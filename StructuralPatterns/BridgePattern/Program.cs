using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var redCircle = new Circle(100, 100, 10, new RedCircle());
            var greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();

            Console.ReadKey();
        }
    }
}
