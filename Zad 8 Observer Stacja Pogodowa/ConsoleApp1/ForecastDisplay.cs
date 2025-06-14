using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // OBSERWATOR – WYŚWIETLA PROGNOZĘ NA PODSTAWIE CIŚNIENIA
    public class ForecastDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            // Prosta logika: wysokie ciśnienie = dobra pogoda
            string forecast = pressure > 1013
                ? "Słoneczna pogoda się utrzyma"
                : "Możliwy deszcz lub pogorszenie pogody";

            Console.WriteLine($"[Prognoza] {forecast}");
        }
    }
}
