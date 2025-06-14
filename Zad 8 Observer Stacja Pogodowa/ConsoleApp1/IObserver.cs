using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // INTERFEJS OBSERWATORA
    // Wszystkie klasy obserwujące muszą implementować tę metodę
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
