namespace SimpleFactory
{
    public class OperationMul:Operation
    {
        public override double GetResult()
        {
            double result=0;
            result =NumberB*NumberB;
            return result;
        }
    }
}