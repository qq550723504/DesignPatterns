using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IContainer
    {
        public IIterator GetIterator();
    }
}
