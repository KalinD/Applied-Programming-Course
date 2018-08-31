using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_wars {
    class Ship {
        string name;
        double metal;
        double mineral;

        public string Name {
            get => name;
            set {
                if (value == "") {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public double Metal {
            get => metal;
            set {
                if (value < 0) {
                    throw new ArgumentException("Amount cannot be negative");
                }
                metal = value;
            }
        }

        public double Mineral {
            get => mineral;
            set {
                if (value < 0) {
                    throw new ArgumentException("Amount cannot be negative");
                }
                mineral = value;
            }
        }

        public Ship(string name, double metal, double mineral){
            Name = name;
            Metal = metal;
            Mineral = mineral;
        }
    }
}
