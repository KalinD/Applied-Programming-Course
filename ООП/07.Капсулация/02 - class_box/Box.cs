using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_box {
    class Box {
        private double length;
        private double width;
        private double height;

        public double Lenght => length;
        public double Width => width;
        public double Height => height;

        public Box(double length, double width, double height){
            this.length = length;
            this.width = width;
            this.height = height;
        }
        
        public double Surface(){
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public double LateralSurface(){
            return 2 * length * height + 2 * width * height;
        }

        public double Volume(){
            return length * width * height;
        }

    }
}
