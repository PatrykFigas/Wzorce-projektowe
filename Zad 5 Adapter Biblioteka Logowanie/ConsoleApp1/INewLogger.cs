using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // NOWY INTERFEJS – oferowany przez nową bibliotekę logowania
    public interface INewLogger
    {
        // Metoda do logowania z określonym poziomem logowania (np. INFO, ERROR)
        void WriteLog(string level, string message);
    }
}
