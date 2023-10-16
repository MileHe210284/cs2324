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
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Square with Length: {Length} and Width: {Width}");
        }
        public override void ShapeInfo()
        {
            base.ShapeInfo();
            Console.WriteLine("Square");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Circumference: {Circumference()}");
        }
    }
}
