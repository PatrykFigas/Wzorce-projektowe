namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            while (true)
            {
                Console.WriteLine("Internetowe konto bankowe. Wpisz swój nr konta:");

                Console.WriteLine("1. Wprowadz nr konta");
                Console.WriteLine("2. Sprawdź saldo");
                Console.WriteLine("3. Wpłać pieniądze na konto");
                Console.WriteLine("4. Wypłać pieniądze z konta");
                Console.WriteLine("5. Zamknij program");

                int wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        {
                            account.PobierzNrKonta();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            account.PobierzBiezaceSaldo();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            account.WplataNaKonto();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            account.WyplataZKonta();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }

            }
        }   
    }
}
