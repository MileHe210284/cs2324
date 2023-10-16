using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231009_shapesAbstract
{
    class Circle : Oval
    {
        public Circle() { }
        public Circle(string color, double radius) : base(color, "Circle", radius, radius)
        {
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing an {Color} Circle with radius: {A}");
        }

        // infos
        public override void ShapeInfo()
        {
            base.ShapeInfo();
            Console.WriteLine($"Radius: {A}");
        }
    }
}


