namespace Observer
{
    class Program
    {
        public static void Main(string[] args) { }
    }
    abstract class Subject
    {
        protected List<Observer> _observers;
        public void AddObserver(Observer observee)
        {
            _observers.Add(observee);
        }
        public void RemoveObserver(Observer observee) {
            _observers.Remove(observee);
        }
        public void notify()
        {
            foreach (Observer observer in _observers) {
                observer.update();
            }
        }
    }
    abstract class Observer 
    {
        public abstract void update();
    }
    class ConcreteSubject : Subject
    {
        private char _state; // can be any type
        public char getState() { return _state; }
        public void setState(char state) { _state = state; }
    }
    class ConcreteObserver : Observer
    {
        private ConcreteSubject _subject;
        private char _subjectState;
        public ConcreteObserver()
        {
            _subject = new ConcreteSubject();
            _subjectState = 'A'; // initial state, can be any
        }
        public override void update()
        {
            // logic goes here
            _subjectState = _subject.getState();
        }
    }
}