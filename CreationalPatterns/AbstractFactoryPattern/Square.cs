using System;

namespace AbstractFactoryPattern
{
    public class Square:IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}