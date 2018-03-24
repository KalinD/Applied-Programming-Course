using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_of_nums {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] count = new int[nums.Max() + 1];
            foreach(int num in nums){
                count[num]++;
            }
            for(int i = 0; i < count.Length; i++){
                if(count[i] != 0){
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}
