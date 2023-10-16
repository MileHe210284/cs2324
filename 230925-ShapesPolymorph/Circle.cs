using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230925_ShapesPolymorph
{
    class Circle : Oval
    {
        public Circle() { }
        public Circle(string color, double radius) : base(color, "Circle", radius, radius)
        {
        }

        // infos
        public override void ShapeInfo()
        {
            base.ShapeInfo();
            Console.WriteLine($"Radius: {A}");
        }
    }
}


