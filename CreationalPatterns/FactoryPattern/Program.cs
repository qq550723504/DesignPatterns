using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();
            //获取 Circle 的对象，并调用它的 draw 方法
            var shape1 = shapeFactory.GetShape("CIRCLE");

            //调用 Circle 的 draw 方法
            shape1.Draw();

            //获取 Rectangle 的对象，并调用它的 draw 方法
            var shape2 = shapeFactory.GetShape("RECTANGLE");

            //调用 Rectangle 的 draw 方法
            shape2.Draw();

            //获取 Square 的对象，并调用它的 draw 方法
            var shape3 = shapeFactory.GetShape("SQUARE");

            //调用 Square 的 draw 方法
            shape3.Draw();

            Console.ReadKey();
        }
    }
}
