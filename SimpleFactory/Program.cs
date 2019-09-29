using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper=OperationFactory.CreateOperation("+");
            oper.NumberA=1;
            oper.NumberB=2;
            double result=oper.GetResult();
        }
    }

    
}
