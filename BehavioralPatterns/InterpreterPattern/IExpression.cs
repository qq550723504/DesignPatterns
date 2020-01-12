using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public interface IExpression
    {
        public bool Interpret(string context);
    }
}
