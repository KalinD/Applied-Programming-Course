using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defining_geometry_class {
    static class Geometry {
        static public double SquarePerimeter(double side){
            return side * 4;
        }

        static public double SquareArea(double side){
            return side * side;
        }

        static public double RectanglePerimeter(double a, double b){
            return (a + b) * 2;
        }

        static public double RectangleArea(double a, double b){
            return a * b;
        }

        static public double CircleArea(double r){
            return Math.PI * r * r;
        }

    }
}
