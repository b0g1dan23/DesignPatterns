namespace Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        protected Singleton() { }
        public static Singleton getInstance()
        {
            if(_instance == null)
                _instance = new Singleton();
            return _instance;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            if (s1 != s2)
                throw new Exception("Not implemented correctly!\nTwo objects must be equal in Singleton pattern");
            Console.WriteLine("Singleton pattern successfully implemented!");
        }
    }
}