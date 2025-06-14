using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // INTERFEJS PODMIOTU (SUBJECT)
    // Klasa, która przechowuje dane pogodowe i powiadamia obserwatorów
    public interface ISubject
    {
        void RegisterObserver(IObserver o);    // Dodaj obserwatora
        void RemoveObserver(IObserver o);      // Usuń obserwatora
        void NotifyObservers();                // Powiadom wszystkich obserwatorów
    }
}
