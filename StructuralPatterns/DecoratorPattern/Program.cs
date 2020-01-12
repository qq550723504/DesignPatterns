using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var redCircle = new RedShapeDecorator(new Circle());
            var redRectangle = new RedShapeDecorator(new Rectangle());

            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();

            Console.ReadKey();
        }
    }
}
