using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Istniejąca klasa, której nie chcemy lub nie możemy zmieniać
    public class Square
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }
    }
}
