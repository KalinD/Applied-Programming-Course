using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporting_freight {
    class Freight {
        private string name;
        private double weight;

        public string Name{
            get => name;
            set => name = value;
        }

        public double Weight{
            get => weight;
            set => weight = value;
        }

        public Freight(string name, double weight){
            this.name = name;
            this.weight = weight;
        }
    }
}
