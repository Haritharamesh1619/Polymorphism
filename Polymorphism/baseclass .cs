using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //base class of overriding followed by" virtual "keyword
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape");
        }
    }
}
