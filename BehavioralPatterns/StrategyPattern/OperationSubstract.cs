namespace StrategyPattern
{
    public class OperationSubstract : IStrategy
    {
        public virtual int DoOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
