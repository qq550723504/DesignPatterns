using System;

namespace VisitorPattern
{
    public class Computer : IComputerPart
    {
        public readonly IComputerPart[] parts;

        public Computer() 
        {
            parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }
        public virtual void Accept(IComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
    }
}
