using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Interfejs dla każdego handlera w łańcuchu
    public interface ISupportHandler
    {
        // Metoda do ustawienia kolejnego handlera w łańcuchu
        ISupportHandler SetNext(ISupportHandler handler);

        // Obsługuje zgłoszenie lub przekazuje dalej
        void Handle(Ticket ticket);
    }
}
