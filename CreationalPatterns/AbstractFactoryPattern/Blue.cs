using System;

namespace AbstractFactoryPattern
{
    public class Blue : IColor
    {
        public virtual void Fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}