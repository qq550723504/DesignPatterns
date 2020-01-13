using System;

namespace ObserverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            Subject = subject;
            Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Octal String:{Convert.ToString(Subject.GetState(),8)}");
        }
    }
}
