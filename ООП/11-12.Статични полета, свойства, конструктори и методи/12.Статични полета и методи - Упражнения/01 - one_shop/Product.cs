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
        private double amount;

        public string Name{
            get => name;
            set => name = value;
        }

        public string Barcode{
            get => barcode;
            set => barcode = value;
        }

        public double Price{
            get => price;
            set => price = value;
        }

        public double Amount{
            get => amount;
            set => amount = value;
        }

        public Product(string barcode, string name, double price, double amount){
            Barcode = barcode;
            Name = name;
            Price = price;
            Amount = amount;
        }

        public Product() : this(null, null, 0, 0){ }
    }
}
