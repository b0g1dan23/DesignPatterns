namespace Strategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            Context ctx = new Context(new StrategyA());
            ctx.showStrategy();

            ctx.setStrategy(new StrategyB());
            ctx.showStrategy();

            ctx.setStrategy(new StrategyC());
            ctx.showStrategy();
        }
    }
    class Context
    {
        Strategy _strategy;
        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }
        public void showStrategy()
        {
            _strategy.StrategyAlgorithm();
        }
        public void setStrategy(Strategy strategy)
        {
            _strategy = strategy;
        }
    }
    abstract class Strategy
    {
        public abstract void StrategyAlgorithm();
    }
    class StrategyA : Strategy
    {
        public override void StrategyAlgorithm()
        {
            Console.WriteLine("Algo A");
        }
    }
    class StrategyB : Strategy
    {
        public override void StrategyAlgorithm()
        {
            Console.WriteLine("Algo B");
        }
    }
    class StrategyC : Strategy
    {
        public override void StrategyAlgorithm()
        {
            Console.WriteLine("Algo C");
        }
    }
}