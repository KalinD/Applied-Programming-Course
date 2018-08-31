using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gone_shopping {
    class Person {
        private string name;
        private double money;
        private List<Product> products;

        public string Name{
            get => name;
            set{
                if(value == null){
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public double Money {
            get => money;
            set{
                if(value < 0){
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<Product> Products{
            get => products;
        }

        public Person(){
            products = new List<Product>();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < products.Count; i++){
                if(i != 0){
                    sb.Append(", ");
                }
                sb.Append(products[i].Name);
            }
            return sb.ToString();
        }
    }
}
