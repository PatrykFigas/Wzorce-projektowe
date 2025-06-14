namespace ConsoleApp1
{
    internal class Program
    {

        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
           

            
            
            
            while(true)
            {
                Console.Clear();
                Console.WriteLine("\nSystem Zarządzania Pracownikami");
                Console.WriteLine("1. Dodaj pracownika");
                Console.WriteLine("2. Wyświetl wszystkich pracowników");
                Console.WriteLine("3. Oblicz wynagrodzenie");
                Console.WriteLine("4. Zakończ program");
                Console.Write("Wybierz opcję: ");

                string choice = Console.ReadLine();

                
                switch (choice)
                {
                    case "1":
                        {

                            DodajPracownika();
                           
                            break;
                        }

                    case "2":
                        {
                            WyswietlPracownikow();
                            break;
                        }

                    case "3":
                        {
                            ObliczWynagrodzenie();
                            break;
                        }
                    case "4":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                            break;
                        }
                }


            }
        }
    
        // dodanie nowego pracownika do listy employees
        static void DodajPracownika()
        {
            Console.Write("Podaj imię i nazwisko: ");
            string name = Console.ReadLine();

            Console.Write("Podaj ID: ");
            // walidacja poprawności wprowadzonych danych
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Błąd! ID musi być liczbą całkowitą.");
                return;
            }
  
            Console.Write("Podaj liczbę godzin: ");
            // walidacja poprawności wprowadzonych danych
            if (!double.TryParse(Console.ReadLine(), out double hours))
            {
                Console.WriteLine("Błąd! Liczba godzin musi być liczbą.");
                return;
            }

            Console.Write("Podaj stanowisko (Programista/Grafik/DevOps): ");
            string position = Console.ReadLine().ToLower();

            Employee employee;
            switch (position)
            {
                case "programista":
                    {
                        employee = new Programista(name, id, hours);
                        break;
                    }
                case "grafik":
                    {
                        employee = new Grafik(name, id, hours);
                        break;
                    }
                case "devops":
                    {
                        employee = new DevOps(name, id, hours);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nieznane stanowisko. Spróbuj ponownie.");
                        return;
                    }
            }

            employees.Add(employee);
            Console.WriteLine("Pracownik dodany pomyślnie!");
            Console.ReadKey();
        }

        //wyświetlanie liczby pracowników
        static void WyswietlPracownikow()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Brak pracowników w systemie.");
            }
            else
            {
                Console.WriteLine("\nLista pracowników:");
                foreach (var emp in employees)
                {
                    emp.WyswietlInformacje();
                }
            }
            Console.ReadKey();
        }

        // obliczanie wynagrodzenia
        static void ObliczWynagrodzenie()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Brak pracowników do obliczenia wynagrodzenia.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Dla którego pracownika mam wyliczyć wynagrodzenie?");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Imię i nazwisko: {emp.Name}");
            }
            
            Console.Write("Podaj ID pracownika: ");
            // walidacja poprawności wprowadzonego ID
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Błąd! ID musi być liczbą.");
                Console.ReadKey();
                return;
            }
            // wyszukiwanie w liście pracownika 
            Employee selectedEmployee = employees.Find(e => e.Id == id);
            if (selectedEmployee == null)
            {
                Console.WriteLine("Pracownik o podanym ID nie istnieje.");
            }
            else
            {
                double wynagrodzenie = selectedEmployee.ObliczWyplate();
                Console.WriteLine($"Wynagrodzenie dla {selectedEmployee.Name}: {wynagrodzenie} PLN");
            }
            Console.ReadKey();
        }
    }
}


