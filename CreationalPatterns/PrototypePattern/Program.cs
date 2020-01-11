using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.LoadCache();

            var clonedShape = ShapeCache.GetShape("1");
            Console.WriteLine("Shape : " + clonedShape.GetEntity());

            var clonedShape2 = ShapeCache.GetShape("2");
            Console.WriteLine("Shape : " + clonedShape2.GetEntity());

            var clonedShape3 = ShapeCache.GetShape("3");
            Console.WriteLine("Shape : " + clonedShape3.GetEntity());

            Console.ReadKey();
        }
    }
}
