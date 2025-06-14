using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // KLASA STACJI POGODOWEJ
    // Przechowuje dane pogodowe i informuje obserwatorów o zmianach
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers;     // Lista obserwatorów
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherStation()
        {
            observers = new List<IObserver>(); // Inicjalizacja listy obserwatorów
        }

        // Dodaj obserwatora do listy
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        // Usuń obserwatora z listy
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        // Powiadom wszystkich obserwatorów o nowych danych
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                // Przekazujemy aktualne dane każdemu obserwatorowi
                observer.Update(temperature, humidity, pressure);
            }
        }

        // Ustaw nowe dane pogodowe i powiadom obserwatorów
        public void SetMeasurements(float temp, float hum, float pres)
        {
            temperature = temp;
            humidity = hum;
            pressure = pres;
            NotifyObservers(); // Automatycznie wywołujemy informowanie obserwatorów
        }
    }
}
