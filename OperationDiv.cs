namespace SimpleFactory
{
    public class OperationDiv:Operation
    {
        public override double GetResult()
        {
            double result=0;
            if(NumberB==0)
                throw new System.Exception("被除数不能为0");
            result=NumberA/NumberB;
            return result;
        }
    }
}