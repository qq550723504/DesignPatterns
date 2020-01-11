using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Bottle:IPacking
    {
        public virtual string Pack => "Bottle";
    }
}
