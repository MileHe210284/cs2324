using System;

namespace _230925_ShapesPolymorph
{
    class Program
    {
        static void Main()
        {// make new obj

            Shape genericShape = new Shape("Blue", "Generic Shape");
            Oval oval = new Oval("Black", "Oval", 1, 2);
            Circle circle = new Circle("Brown", 9);
            Rectangle rectangle = new Rectangle("Green", "Rectangle", 20, 18);
            Square square = new Square("Yellow", 10);




            //informations abt the obj
            Console.WriteLine("Informationen:");

            Console.WriteLine("Generic Shape:");
            genericShape.Draw();
            genericShape.ShapeInfo();
            Console.WriteLine();

            Console.WriteLine("Oval:");
            oval.Draw();
            oval.ShapeInfo();
            Console.WriteLine();

            Console.WriteLine("Circle:");
            circle.Draw();
            circle.ShapeInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle:");
            rectangle.Draw();
            rectangle.ShapeInfo();
            Console.WriteLine();

            Console.WriteLine("Square");
            square.Draw();
            square.ShapeInfo();            
        }
    }
}

