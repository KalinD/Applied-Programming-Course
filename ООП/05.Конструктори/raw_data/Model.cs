using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raw_data {
    class Model {
        private string name;

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public Model(string name){
            this.name = name;
        }
    }
}
