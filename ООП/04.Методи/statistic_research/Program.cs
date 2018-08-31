using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistic_research {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            List<Person> family = new List<Person>();
            for(int i = 0; i < n; i++){
                string input = Console.ReadLine();
                Person person = new Person(input.Split()[0], int.Parse(input.Split()[1]));
                family.Add(person);
            }
            foreach(Person member in family){
                if(member.Age > 30){
                    Console.WriteLine($"{member.Name} - {member.Age}");
                }
            }
        }
    }
}
