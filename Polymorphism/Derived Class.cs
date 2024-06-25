using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
 
    // Circle class inheriting from Shape
    class Circle : Shape
    {
        //derived class of overriding followed by" override "keyword
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }


// Rectangle class inheriting from Shape
class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

// Triangle class inheriting from Shape
class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    }

}
