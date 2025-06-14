using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Logger
    {
        private static Logger _instance;
        private List<string> _logMessages;

        // Prywatny konstruktor
        private Logger()
        {
            _logMessages = new List<string>();
        }

        // Właściwość statyczna zwracająca instancję
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Logger();
                return _instance;
            }
        }

        // Metoda do logowania komunikatów
        public void Log(string message)
        {
            _logMessages.Add(message);
        }

        // Metoda do pobierania komunikatów
        public List<string> GetLogs()
        {
            return new List<string>(_logMessages); // Zwracamy kopię listy
        }
    }
}
