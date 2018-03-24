using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_combining {
    class Program {
        static void Main(string[] args) {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<int> result = new List<int>();
            for (int i = input.Count - 1; i >= 0; i--){
                List<string> current = input[i].Trim().Split(' ').ToList();
                for(int j = 0; j < current.Count; j++){
                    current[j] = current[j].TrimEnd();
                    current[j] = current[j].TrimStart();
                    if(current[j] != ""){
                        result.Add(int.Parse(current[j]));
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
