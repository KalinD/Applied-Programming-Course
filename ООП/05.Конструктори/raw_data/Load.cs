using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raw_data {
    class Load {
        //<ТеглоНаТовара> <ТипНаТовара> 
        private int weight;
        private string type;

        public int Weight{
            get{
                return weight;
            }
            set{
                weight = value;
            }
        }

        public string Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }
        public Load(int weight, string type){
            this.weight = weight;
            this.type = type;
        }
    }
}
