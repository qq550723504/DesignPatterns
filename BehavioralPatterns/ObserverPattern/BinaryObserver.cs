using System;

namespace ObserverPattern
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            Subject = subject;
            Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Binary String:{Convert.ToString(Subject.GetState(),2)}");
        }
    }
}
