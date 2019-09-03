using System;
using System.Collections.Generic;
using System.Text;

namespace TileRepairs.Models {
    class Plate {
        private double width;
        private double height;

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }
        public double PlacementTime { get; } = 0.2;

        public Plate(double height, double width) {
            Height = height;
            Width = width;
        }

        public double CalculateArea() {
            return Width * Height;
        }
    }
}
