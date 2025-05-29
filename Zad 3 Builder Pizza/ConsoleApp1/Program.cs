namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaBuilder builder = new ConcretePizzaBuilder();
            Director director = new Director();

            director.Construct(builder);
            Pizza pizza = builder.GetPizza();

            Console.WriteLine(pizza.ToString());
        }
    }
}
