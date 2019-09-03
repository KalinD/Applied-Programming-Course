using System;
using System.Collections.Generic;
using System.Text;

namespace TileRepairs.Models {
    class Ground{
        private int side;

        public int Side { get => side; set => side = value; }

        public Ground(int side) {
            Side = side;
        }

        public int CalculateArea() {
            return Side * Side;
        }
    }
}
