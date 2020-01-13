namespace ObserverPattern
{
    public abstract class Observer
    {
        protected Subject Subject;
        public abstract void Update();
    }
}
