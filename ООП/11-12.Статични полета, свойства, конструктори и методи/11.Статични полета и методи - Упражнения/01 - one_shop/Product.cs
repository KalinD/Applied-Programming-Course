using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_shop {
    class Product {
        private string name;
        private string barcode;
        private double price;
        private double quantity;

        public string Name{
            get => name;
            set => name = value;
        }

        public string Barcode {
            get => barcode;
            set => barcode = value;
        }

        public double Price {
            get => price;
            set => price = value;
        }

        public double Quantity {
            get => quantity;
            set => quantity = value;
        }
    }
}
