using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oldest_family_member {
    class Program {
        static void Main(string[] args) {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null) {
                throw new Exception();
            }
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for(int i = 0; i < n; i++){
                Person person = new Person();
                string input = Console.ReadLine();
                person.Name = input.Split()[0];
                person.Age = int.Parse(input.Split()[1]);
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember().Name + " " + family.GetOldestMember().Age);
        }
    }
}
