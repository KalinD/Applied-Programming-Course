using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extreme_list {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> extreme = new List<int>();
            foreach(int num in nums){
                if(num == nums.Min() || num == nums.Max()){
                    extreme.Add(num);
                }
            }
            extreme.Sort();
            Console.WriteLine(string.Join(" ", extreme));
        }
    }
}
