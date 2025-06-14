using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // KOMPONENT KLIENTA – używa starego loggera IOldLogger
    public class SomeLegacyComponent
    {
        // Logger zgodny ze starym interfejsem
        private readonly IOldLogger _logger;

        // Iniekcja loggera przez konstruktor
        public SomeLegacyComponent(IOldLogger logger)
        {
            _logger = logger;
        }

        // Przykładowa metoda, która korzysta z loggera
        public void DoStuff()
        {
            _logger.LogMessage("Legacy process started.");
        }
    }
}
