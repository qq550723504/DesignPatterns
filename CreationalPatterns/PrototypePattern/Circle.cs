using System;

namespace PrototypePattern
{
    public class Circle : Shape
    {
        public Circle() 
        {
            _entity = "Circle";
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
