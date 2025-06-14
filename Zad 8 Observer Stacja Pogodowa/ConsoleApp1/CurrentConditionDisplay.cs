using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // OBSERWATOR – WYŚWIETLA AKTUALNE WARUNKI
    public class CurrentConditionsDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"[Aktualne warunki] Temp: {temperature}°C, Wilgotność: {humidity}%");
        }
    }
}
