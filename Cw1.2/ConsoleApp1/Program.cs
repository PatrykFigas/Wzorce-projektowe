namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Vehicles auto1 = new Vehicles();
            Cars car1 = new Cars();

            Console.WriteLine("KLASA VEHICLES");
            auto1.read();
            auto1.show();

            Console.WriteLine("KLASA CARS");
            car1.read1();
            car1.show1();

        }
    }
}
