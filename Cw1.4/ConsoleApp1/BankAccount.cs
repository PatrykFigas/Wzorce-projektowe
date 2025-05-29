using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccount
    {
        private string NumerKonta { get; set; }
        private decimal Saldo = 100;
        private decimal Wplata { get; set; }
        private decimal Wyplata { get; set; }
        

        public void PobierzNrKonta()
        {
            Console.WriteLine("Podaj numer konta bankowego (np 1234)");
            NumerKonta = Console.ReadLine();
            Console.WriteLine("Numer konta został zapisany.");
           
        }
        public void PobierzBiezaceSaldo()
        {
            Console.WriteLine($"Konto nr: {NumerKonta}");
            Console.WriteLine($"Twoje saldo wynosi: {Saldo} PLN");
        }
        public void WplataNaKonto()
        {
            Console.WriteLine($"Konto nr: {NumerKonta}");
            Console.WriteLine("Ile chcesz wpłacić na konto?");
            Wplata = Convert.ToDecimal(Console.ReadLine());
            Saldo += Wplata;
            Console.WriteLine($"Pomyślnie dodano {Wplata} PLN do twojego konta.\nAktualne saldo Twojego konta wynosi: {Saldo} PLN.");
        }
        public void WyplataZKonta()
        {
            Console.WriteLine($"Konto nr: {NumerKonta}");
            Console.WriteLine("Ile chcesz wypłacić z konta?");
            Wyplata = Convert.ToDecimal(Console.ReadLine());
            Saldo -= Wyplata;
            Console.WriteLine($"Pomyślnie wypłacono {Wyplata} PLN.\nSaldo Twojego konta wynosi: {Saldo} PLN.");
        }



    }
}
