using System;
using System.Collections.Generic;
using System.Text;

namespace TransportPrice.Models {
    class PriceViewModel {
        private double price;

        public double Price { get => price; set => price = value; }

        public PriceViewModel(double price) {
            Price = price;
        }
    }
}
