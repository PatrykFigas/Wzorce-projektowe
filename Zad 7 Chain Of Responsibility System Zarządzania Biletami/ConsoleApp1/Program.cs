namespace ConsoleApp1
{
    // Klasa klienta (main) – symuluje działanie systemu
    class Program
    {
        static void Main()
        {
            // Tworzymy konkretne handlery
            var technical = new TechnicalSupportHandler();
            var billing = new BillingSupportHandler();
            var general = new GeneralSupportHandler();

            // Budujemy łańcuch: technical -> billing -> general
            technical.SetNext(billing).SetNext(general);

            // Przykładowe zgłoszenia od klientów
            var tickets = new[]
            {
                new Ticket("Technical", "Nie mogę połączyć się z siecią."),
                new Ticket("Billing", "Na fakturze pojawiła się nieprawidłowa kwota."),
                new Ticket("General", "Jak mogę zmienić hasło?"),
                new Ticket("Other", "Czy mogę uzyskać rabat jako student?")
            };

            // Przekazujemy każde zgłoszenie do pierwszego handlera w łańcuchu
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"\nNowe zgłoszenie: {ticket.Type} – {ticket.Message}");
                technical.Handle(ticket);
            }
        }
    }
}

