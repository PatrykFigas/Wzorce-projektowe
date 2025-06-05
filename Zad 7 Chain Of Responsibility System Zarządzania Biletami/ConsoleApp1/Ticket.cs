using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Klasa Ticket – reprezentuje zgłoszenie od klienta
    public class Ticket
    {
        public string Type { get; }     // Typ zgłoszenia: "Technical", "Billing", "General", itd.
        public string Message { get; }  // Opis problemu lub zapytania

        public Ticket(string type, string message)
        {
            Type = type;
            Message = message;
        }
    }
}
