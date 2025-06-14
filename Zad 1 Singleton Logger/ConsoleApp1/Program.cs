namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            logger1.Log("Pierwszy komunikat");
            logger1.Log("Drugi komunikat");

            Logger logger2 = Logger.Instance;
            logger2.Log("Trzeci komunikat");

            Console.WriteLine("Logi logger1:");
            foreach (var log in logger1.GetLogs())
            {
                Console.WriteLine(log);
            }

            Console.WriteLine("\nCzy logger1 == logger2? " + (logger1 == logger2));
        }
    }
}
