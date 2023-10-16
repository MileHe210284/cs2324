using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231009_shapesAbstract
{
    class Rectangle : Shape
    {
        //Properties
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle() { }

        public Rectangle(string color, string name, double length, double width) : base(color, name)
        {
            Length = length;
            Width = width;
        }

        //methods
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Rectangle with Length: {Length} and Width: {Width}");
        }
        public double Area()
        {
            return Length * Width;
        }


        public double Circumference()
        {
            return 2 * (Length + Width);
        }
        //infos

        public override void ShapeInfo()
        {
            base.ShapeInfo();
            Console.WriteLine("Rectangle");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Circumference: {Circumference()}\n");
        }
    }
}
