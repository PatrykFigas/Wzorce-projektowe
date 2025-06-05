namespace ConsoleApp1
{
    // PROGRAM TESTUJĄCY SYSTEM ZAMAWIANIA KAWY
    class Program
    {
        static void Main()
        {
            // Tworzymy bazową kawę – espresso
            ICoffee order = new Espresso();

            // Dodajemy mleko
            order = new MilkDecorator(order);

            // Dodajemy cukier
            order = new SugarDecorator(order);

            // Dodajemy czekoladę
            order = new ChocolateDecorator(order);

            // Wyświetlamy końcowy opis i cenę napoju
            Console.WriteLine($"Zamówienie: {order.GetDescription()}");
            Console.WriteLine($"Cena: {order.GetCost()} zł");
        }
    }
}

