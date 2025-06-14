using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // IMPLEMENTACJA NOWEGO LOGGERA – symuluje nowoczesną bibliotekę logowania
    public class NewLogger : INewLogger
    {
        // Wyświetla wiadomość z poziomem logowania
        public void WriteLog(string level, string message)
        {
            Console.WriteLine($"[{level}] {message}");
        }
    }
}
