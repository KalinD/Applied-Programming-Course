using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldest_family_member {
    class Family {
        private List<Person> members = new List<Person>();

        public void AddMember(Person member){
            members.Add(member);
        }

        public Person GetOldestMember(){
            int oldest = members.Max(x => x.Age);
            foreach(Person member in members){
                if(member.Age == oldest){
                    return member;
                }
            }
            return members[0];
        }
    }
}
