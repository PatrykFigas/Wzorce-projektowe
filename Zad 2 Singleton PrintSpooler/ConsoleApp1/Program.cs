class Program
{
    static void Main(string[] args)
    {
        var spooler1 = PrintSpooler.GetInstance();
        var spooler2 = PrintSpooler.GetInstance();

        Console.WriteLine("Czy to ta sama instancja? " + (spooler1 == spooler2));

        spooler1.AddJob("Faktura_123.pdf");
        spooler2.AddJob("Zdjęcie.png");
        spooler1.AddJob("Raport.docx");

        spooler1.PrintJob();
        spooler2.PrintJob();
        spooler1.PrintJob();
        spooler2.PrintJob(); // powinno być pusto
    }
}
