using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230925_ShapesPolymorph
{
    class Oval : Shape
    {
        //properties
        public double A { get; set; }
        public double B { get; set; }

        public Oval() { }
        public Oval(string color, string name, double a, double b) : base(color, name)
        {
            A = a;
            B = b;
        }

        //methods
        public override void Draw()
        {
            Console.WriteLine($"Drawing an {Color} Oval with A: {A} and B: {B}");
        }
        public virtual double Area()
        {
            return Math.PI * A * B;
        }
        public virtual double Circumference()
        {
            return 2 * Math.PI * Math.Sqrt((A * A + B * B) / 2);
        }
        //infos
        public override void ShapeInfo()
        {
            base.ShapeInfo();
            Console.WriteLine($"A: {A}");
            Console.WriteLine($"B: {B}");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Circumference: {Circumference()}");
        }

    }
}
