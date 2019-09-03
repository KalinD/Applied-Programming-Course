using System;
using System.Collections.Generic;
using System.Text;

namespace TileRepairs.Models {
    class Bench {
        private int width;
        private int height;

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public Bench(int height, int width) {
            Height = height;
            Width = width;
        }

        public int CalculateArea() {
            return Width * Height;
        }
    }
}
