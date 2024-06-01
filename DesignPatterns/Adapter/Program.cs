namespace Adapter
{
    class Program
    {
        public static void Main(string[] args) {
            Source xmpl = new Source();
            Target adapter = new SourceToTargetAdapter("Initial state",xmpl);

            adapter.DoTheWork();
        }
    }

    class Target 
    {
        private string _state;
        public Target(string state) 
        { 
            _state = state;
        }
        public string getState()
        {
            return _state;
        }
        public virtual void DoTheWork()
        {
            Console.WriteLine("Call from Target class");
        }
    }
    class Source
    {
        public void DoSomething()
        {
            Console.WriteLine("Doing something");
        }
    }
    class SourceToTargetAdapter : Target
    {
        private Source _source;
        public SourceToTargetAdapter(string state, Source source) : base(state)
        {
            _source = source;
        }
        public override void DoTheWork()
        {
            Console.WriteLine("Call from adapter");
        }
    }
}