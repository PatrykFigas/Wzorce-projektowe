namespace ConsoleApp1
{
    // PROGRAM GŁÓWNY
    // Tworzy stację pogodową i rejestruje obserwatorów
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy stację pogodową (subject)
            WeatherStation station = new WeatherStation();

            // Tworzymy dwa niezależne wyświetlacze (obserwatorzy)
            IObserver currentDisplay = new CurrentConditionsDisplay();
            IObserver forecastDisplay = new ForecastDisplay();

            // Rejestrujemy obserwatorów w stacji pogodowej
            station.RegisterObserver(currentDisplay);
            station.RegisterObserver(forecastDisplay);

            // Symulujemy napływ nowych danych pogodowych
            Console.WriteLine(">>> Pierwszy pomiar:");
            station.SetMeasurements(25.5f, 60f, 1012f); // niższe ciśnienie

            Console.WriteLine("\n>>> Drugi pomiar:");
            station.SetMeasurements(22.3f, 70f, 1015f); // wyższe ciśnienie

            Console.WriteLine("\n>>> Trzeci pomiar:");
            station.SetMeasurements(19.0f, 85f, 1008f); // niższe ciśnienie
        }
    }
}

