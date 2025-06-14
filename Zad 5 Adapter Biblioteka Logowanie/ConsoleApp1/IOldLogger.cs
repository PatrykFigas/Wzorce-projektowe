using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // STARY INTERFEJS – używany przez istniejący kod
    public interface IOldLogger
    {
        // Metoda do logowania wiadomości (bez poziomu logowania)
        void LogMessage(string message);
    }
}
