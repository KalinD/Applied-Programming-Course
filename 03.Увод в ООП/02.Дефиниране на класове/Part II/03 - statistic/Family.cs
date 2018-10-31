using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistic {
    class Family {
        private List<Person> members = new List<Person>();
        public List<Person> Members{
            get{
                return members;
            }
            set{
                members = value;
            }
        }
        public override string ToString() {
            string output = "";
            for(int i = 0; i < members.Count; i++){
                output += "\n" + members[i].Name + " - " + members[i].Age;
            }
            return output;
        }
    }
}
