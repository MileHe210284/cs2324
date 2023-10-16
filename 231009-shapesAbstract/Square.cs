using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231009_shapesAbstract
{
    class Square : Rectangle
    {
        // Konstruktor
        public Square(string color, double sideLength) : base(color, "Square", sideLength, sideLength)
        {

        }
    }
}
