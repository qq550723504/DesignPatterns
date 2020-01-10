using System;

namespace AbstractFactoryPattern
{
    public class Green : IColor
    {
        public virtual void Fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}