using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPrice.Models {
    class Train : Vehicle {
        private const double PRICE_PER_KM = 0.06;

        public Train() : base(PRICE_PER_KM, PRICE_PER_KM){ }
    }
}
