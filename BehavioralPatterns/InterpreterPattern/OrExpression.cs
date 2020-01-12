using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class OrExpression : IExpression
    {
        private readonly IExpression _expr1 = null;
        private readonly IExpression _expr2 = null;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }
        public virtual bool Interpret(string context)
        {
            return _expr1.Interpret(context) || _expr2.Interpret(context);
        }
    }
}
