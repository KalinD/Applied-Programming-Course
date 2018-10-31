using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google {
    class Pokemon {
        //<имеНаПокемон> <типНаПокемона>
        private string name;
        private string type;

        public string Type {
            get => type;
            set => type = value;
        }


        public string Name {
            get { return name; }
            set { name = value; }
        }

        public override string ToString() {
            return $"{name} {type}\n";
        }
    }
}
