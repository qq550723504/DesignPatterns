using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface IComputerPartVisitor
    {
        public void Visit(Computer computer);
        public void Visit(Mouse mouse);
        public void Visit(Keyboard keyboard);
        public void Visit(Monitor monitor);
    }
}
