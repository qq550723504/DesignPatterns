namespace InterpreterPattern
{
    public class AndExpression : IExpression
    {
        private IExpression _expr1 = null;
        private IExpression _expr2 = null;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public virtual bool Interpret(string context)
        {
            return _expr1.Interpret(context) && _expr2.Interpret(context);
        }
    }
}
