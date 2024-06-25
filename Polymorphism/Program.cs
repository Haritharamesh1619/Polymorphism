using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class program
    {
        public static void Main()
        {
            // Create instances of different shapes
            Shape[] shapes =
        {
            new Circle(),
            new Rectangle(),
            new Triangle()
        };

            // Draw each shape using polymorphism
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            Console.ReadKey();
        }
    }
}

