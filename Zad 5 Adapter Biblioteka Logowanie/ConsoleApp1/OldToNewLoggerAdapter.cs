using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // ADAPTER – implementuje stary interfejs, korzystając z nowego loggera
    public class OldToNewLoggerAdapter : IOldLogger
    {
        // Pole przechowujące referencję do nowego loggera
        private readonly INewLogger _newLogger;

        // Konstruktor przyjmuje obiekt nowego loggera
        public OldToNewLoggerAdapter(INewLogger newLogger)
        {
            _newLogger = newLogger;
        }

        // Implementacja metody ze starego interfejsu
        // Przekierowuje wiadomość do nowego loggera z domyślnym poziomem "INFO"
        public void LogMessage(string message)
        {
            // Domyślnie ustawiamy poziom logowania na INFO
            _newLogger.WriteLog("INFO", message);
        }
    }
}
