using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistic {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Family family1 = new Family();
            for (int i = 0; i < n; i++) {
                List<string> input = Console.ReadLine().Split().ToList();
                Person person = new Person();
                person.Name = input[0];
                person.Age = int.Parse(input[1]);
                family1.Members.Add(person);
            }
            Family over30 = new Family();
            over30.Members = family1.Members.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            Console.WriteLine(over30.ToString());
        }
    }
}
