using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporting_freight {
    class Truck {
        private string name;
        private double capacity;
        private List<Freight> freights;
        
        public string Name{
            get => name;
            set{
                if(value.Trim().Length == 0){
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }

        public double Capacity {
            get => capacity;
            set{
                if(value < 0){
                    throw new ArgumentException("Weight cannot be negative");
                }
            }
        }

        public List<Freight> Freights {
            get => freights;
            set => freights = value;
        }

        public Truck(string name, double capacity){
            this.name = name;
            this.capacity = capacity;
            freights = new List<Freight>();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            foreach (var freight in freights){
                sb.Append(freight.Name + ", ");
            }
            if(freights.Count == 0){
                sb.Append("Nothing loaded");
            }
            return sb.ToString().TrimEnd(',', ' ');
        }
    }
}




