using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Klasa pomocnicza do wypisywania pola powierzchni
    public class AreaPrinter
    {
        // Funkcja akceptuje obiekt typu IShape
        public static void PrintArea(IShape shape)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}
