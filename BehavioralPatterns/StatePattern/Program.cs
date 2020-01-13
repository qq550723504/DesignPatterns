using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            var startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());

            StopState stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());

            Console.ReadKey();
        }
    }
}
