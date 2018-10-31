using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validating_box {
    class Box {
        private double length;
        private double width;
        private double height;

        public double Length{
            get => length;
            set{
                if(value <= 0){
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }
        public double Width{
            get => width;
            set {
                if (value <= 0) {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height{
            get => height;
            set {
                if (value <= 0) {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public Box(double length, double width, double height) {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Surface() {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public double LateralSurface() {
            return 2 * length * height + 2 * width * height;
        }

        public double Volume() {
            return length * width * height;
        }
    }
}
