using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Handler obsługujący zgłoszenia techniczne
    public class TechnicalSupportHandler : BaseSupportHandler
    {
        public override void Handle(Ticket ticket)
        {
            if (ticket.Type == "Technical")
            {
                Console.WriteLine($"[Dział techniczny] Obsługa zgłoszenia: {ticket.Message}");
            }
            else
            {
                base.Handle(ticket); // Przekazanie dalej
            }
        }
    }
}
