using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_names_2 {
    class Program {
        static void Main(string[] args) {
            List<string> names = Console.ReadLine().Trim().Split(',').ToList<string>();
            for(int i = 0; i < names.Count; i++){
                names[i] = names[i].TrimStart();
                Console.WriteLine(names[i].Split(' ')[1] + " " + names[i].Split(' ')[0]);
            }
        }
    }
}
