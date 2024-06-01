namespace TemplateMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Context ca = new ComponentA();
            Context cb = new ComponentB();
        }
    }
    abstract class Context { 
        public Context() {
            MethodOne();
            MethodTwo();
            MethodThree();
            MethodFour();
        }
        public void MethodOne() {
            Console.WriteLine("Method one");
        }
        public void MethodTwo() {
            Console.WriteLine("Method two");
        }
        /// <summary>
        /// Template method 3
        /// </summary>
        public abstract void MethodThree();
        /// <summary>
        /// Template method 4
        /// </summary>
        public abstract void MethodFour();
    }
    class ComponentA : Context
    {
        public override void MethodFour()
        {
            Console.WriteLine("Component A, method 4");
        }

        public override void MethodThree()
        {
            Console.WriteLine("Component A, method 3");
        }
    }
    class ComponentB : Context
    {
        public override void MethodFour()
        {
            Console.WriteLine("Component B, method 4");
        }
        public override void MethodThree()
        {
            Console.WriteLine("Component B, method 3");
        }
    }
}