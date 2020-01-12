using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();

            Console.ReadKey();
        }
    }
}
