using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_even_nums {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> even = new List<int>();
            foreach(int num in nums){
                if(num % 2 == 0){
                    even.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", even));
        }
    }
}
