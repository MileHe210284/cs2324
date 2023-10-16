using System;

namespace _231009_shapesAbstract
{
    class Program
    {
        static void Main()
        {// array of shapes
            Shape[] shapes = new Shape[4];

            shapes[0]= new Oval("Black", "Oval", 1, 2);
            shapes[1] = new Circle("Brown", 9);
            shapes[2] = new Rectangle("Green", "Rectangle", 20, 18);
            shapes[3] = new Square("Yellow", 10);


            foreach ( Shape shape in shapes) 
            {
                shape.Draw();
                shape.ShapeInfo();
            }

        }
    }
}

