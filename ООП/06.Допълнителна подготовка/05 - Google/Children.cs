using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google {
    class Children {
        private string name;
        private string bDay;

        public string BDay {
            get { return bDay; }
            set { bDay = value; }
        }


        public string Name {
            get { return name; }
            set { name = value; }
        }

        public override string ToString() {
            if(name != null){
                return $"{name} {bDay}\n";
            }
            return "";
        }
    }
}
