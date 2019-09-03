using System;
using System.Collections.Generic;
using System.Text;

namespace PoolPipes.Models {
    class Pipe {
        private int debit;

        public int Debit { get => debit; set => debit = value; }

        public Pipe(int debit) {
            Debit = debit;
        }

        public double CalculateDispensedWater(double hours) {
            return Debit * hours;
        }
    }
}
