using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230925_ShapesPolymorph
{
   class Shape
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

            // Methods
            public virtual void Draw()
            {
                Console.WriteLine($"Drawing a {Color} {Name}");
            }

         //infos
            public virtual void ShapeInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Color: {Color}");
            }
        }
    
}
