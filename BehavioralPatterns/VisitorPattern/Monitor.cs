using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Monitor : IComputerPart
    {
        public virtual void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
