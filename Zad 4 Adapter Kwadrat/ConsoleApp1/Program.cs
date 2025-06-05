namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Tworzymy obiekt klasy Square (np. bok = 5)
            Square square = new Square(5);
            // Owijamy Square w adapter, aby można go było użyć jako IShape
            IShape adaptedSquare = new SquareAdapter(square);
            // Przekazujemy przystosowany obiekt do funkcji, która oczekuje IShape
            AreaPrinter.PrintArea(adaptedSquare);
        }
    }
}
