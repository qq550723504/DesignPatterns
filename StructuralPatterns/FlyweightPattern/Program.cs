using System;

namespace FlyweightPattern
{
    class Program
    {
        private static readonly string[] colors =  {"Red", "Green", "Blue", "White", "Black" };
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                var circle = (Circle)ShapeFactory.GetCircle(GetRandomColor());
                circle.SetX(GetRandomX());
                circle.SetY(GetRandomY());
                circle.SetRadius(100);
                circle.Draw();
            }

            Console.ReadKey();
        }

        private static string GetRandomColor()
        {
            return colors[new Random().Next(0, colors.Length)];
        }
        private static int GetRandomX()
        {
            return (new Random().Next(0,100));
        }
        private static int GetRandomY()
        {
            return (new Random().Next(0,100));
        }
    }
}
