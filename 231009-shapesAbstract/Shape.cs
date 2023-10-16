using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231009_shapesAbstract
{
   abstract class Shape
        {
            // Properties
            public string Color { get; set; }
            public string Name { get; set; }

            public Shape() { }

            public Shape(string color, string name)
            {
                Color = color;
                Name = name;
            }

        // Method
        public abstract void Draw();
         //infos
            public virtual void ShapeInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Color: {Color}");
            }
        }
    
}
