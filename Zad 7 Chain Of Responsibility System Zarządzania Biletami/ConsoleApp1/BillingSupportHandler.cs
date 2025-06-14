using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Handler obsługujący zgłoszenia dotyczące rozliczeń
    public class BillingSupportHandler : BaseSupportHandler
    {
        public override void Handle(Ticket ticket)
        {
            if (ticket.Type == "Billing")
            {
                Console.WriteLine($"[Dział rozliczeń] Obsługa zgłoszenia: {ticket.Message}");
            }
            else
            {
                base.Handle(ticket); // Przekazanie dalej
            }
        }
    }
}
