using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_geometry_class {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            int b = 20;
            Console.WriteLine(Geometry.SquarePerimeter(a)); //40
            Console.WriteLine(Geometry.SquareArea(a)); //100
            Console.WriteLine(Geometry.RectanglePerimeter(a, b)); //60
            Console.WriteLine(Geometry.RectangleArea(a, b)); //200
            Console.WriteLine(Geometry.CircleArea(a)); //314.159
        }
    }
}
