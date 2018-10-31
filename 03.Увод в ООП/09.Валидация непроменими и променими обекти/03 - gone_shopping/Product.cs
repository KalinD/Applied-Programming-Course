using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gone_shopping {
    class Product {
        private string name;
        private double price;

        public string Name{
            get => name;
            set => name = value;
        }

        public double Price {
            get => price;
            set => price = value;
        }
    }
}
