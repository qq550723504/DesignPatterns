using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            Subject = subject;
            Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Hex String:{Convert.ToString(Subject.GetState(),16)}");
        }
    }
}
