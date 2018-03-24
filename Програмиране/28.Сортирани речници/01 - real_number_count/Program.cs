using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace real_number_count {
    class Program {
        static void Main(string[] args) {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();
            foreach(double num in nums){
                if(count.ContainsKey(num)){
                    count[num]++;
                    continue;
                }
                count[num] = 1;
            }
            foreach(var num in count){
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
