using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject
    {
        private readonly IList<Observer> observers= new List<Observer>();
        private int _state;

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            _state = state;
            NotifyAllObservers();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
