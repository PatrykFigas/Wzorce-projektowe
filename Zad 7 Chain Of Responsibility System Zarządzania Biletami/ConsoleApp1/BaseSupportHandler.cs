using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Bazowa klasa implementująca wspólne zachowanie handlerów
    public abstract class BaseSupportHandler : ISupportHandler
    {
        private ISupportHandler _next;

        // Ustawia kolejnego handlera – pozwala budować łańcuch metodą fluent
        public ISupportHandler SetNext(ISupportHandler handler)
        {
            _next = handler;
            return handler;
        }
        // Jeśli handler nie obsługuje zgłoszenia, przekazuje je dalej
        public virtual void Handle(Ticket ticket)
        {
            if (_next != null)
            {
                _next.Handle(ticket);  // Przekazanie do następnego handlera
            }
            else
            {
                // Jeśli żaden handler nie obsłużył zgłoszenia
                Console.WriteLine("Brak odpowiedniego działu do obsługi zgłoszenia.");
            }
        }
    }
}
