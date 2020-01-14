using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());

            Console.ReadKey();
        }
    }
}
