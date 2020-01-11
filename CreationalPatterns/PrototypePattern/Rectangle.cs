using System;

namespace PrototypePattern
{
    public class Rectangle : Shape
    {
        public Rectangle() 
        {
            _entity = "Rectangle";
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
