namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            // Tworzymy instancję nowego loggera (nowa biblioteka)
            INewLogger newLogger = new NewLogger();

            // Tworzymy adapter, który pozwala używać nowego loggera jakby był starym
            IOldLogger adaptedLogger = new OldToNewLoggerAdapter(newLogger);

            // Przekazujemy adapter do komponentu, który używa starego interfejsu
            var legacyComponent = new SomeLegacyComponent(adaptedLogger);

            // Uruchamiamy komponent – logowanie działa przez adapter, mimo że interfejs się zmieni
            legacyComponent.DoStuff();
        }
    }
}
