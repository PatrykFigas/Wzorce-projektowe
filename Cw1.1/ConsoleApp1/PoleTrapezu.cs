using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PoleTrapezu
    {
        public double bok_a;
        public double bok_b;
        public double wys_h;
        public double surface_area;
        public void read_data()
        {            
            Console.WriteLine("Wpisz bok a:");
            bok_a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz bok b:");
            bok_b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz wysokość h:");
            wys_h = Convert.ToDouble(Console.ReadLine());          
        }
        public double process_data()
        {
            surface_area = (bok_a + bok_b) * wys_h / 2;
            return surface_area;
        }
        public void show_results()
        {
            Console.Clear();
            Console.WriteLine($"Bok a wynosi: {bok_a:F1}");
            Console.WriteLine($"Bok b wynosi: {bok_b:F1}");
            Console.WriteLine($"Wysokość trapezu wynosi: {wys_h}");
            Console.WriteLine($"Pole trapezu wynosi: {surface_area:F1}");
        }

    }
}
