using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Adapter – dostosowuje klasę Square do interfejsu IShape
    public class SquareAdapter : IShape
    {
        private readonly Square _square;

        // Konstruktor adaptera przyjmuje obiekt klasy Square
        public SquareAdapter(Square square)
        {
            _square = square;
        }

        // Implementacja metody interfejsu IShape
        // Oblicza pole kwadratu, korzystając z danych z klasy Square
        public double GetArea()
        {
            return _square.Side * _square.Side;
        }
    }

}
