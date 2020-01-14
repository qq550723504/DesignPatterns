using System;

namespace VisitorPattern
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public virtual void Visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }

        public virtual void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse.");
        }

        public virtual void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard.");
        }

        public virtual void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor.");
        }
    }
}
