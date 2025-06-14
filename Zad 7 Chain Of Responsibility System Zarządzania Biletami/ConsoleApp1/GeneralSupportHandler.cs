using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Handler obsługujący zapytania ogólne
    public class GeneralSupportHandler : BaseSupportHandler
    {
        public override void Handle(Ticket ticket)
        {
            if (ticket.Type == "General")
            {
                Console.WriteLine($"[Dział ogólny] Obsługa zgłoszenia: {ticket.Message}");
            }
            else
            {
                base.Handle(ticket); // Przekazanie dalej
            }
        }
    }

}
