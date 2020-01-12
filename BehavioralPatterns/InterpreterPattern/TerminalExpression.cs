namespace InterpreterPattern
{
    public class TerminalExpression : IExpression
    {
        private readonly string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }
        public virtual bool Interpret(string context)
        {
            if (context.Contains(_data))
            {
                return true;
            }
            return false;
        }
    }
}
