using System;

namespace AbstractFactoryPattern
{
    public class Red : IColor
    {
        public virtual void Fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}