using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fold_and_sum {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> row1 = new List<int>();
            int k = nums.Count / 4;
            row1.AddRange(nums.Where(x => nums.IndexOf(x) < k).Reverse());
            List<int> row2 = new List<int>();
            row2.AddRange(nums.Where(x => nums.IndexOf(x) >= k && nums.IndexOf(x) < nums.Count - k));
            row1.AddRange(nums.Where(x => nums.IndexOf(x) >= nums.Count - k && nums.IndexOf(x) < nums.Count).Reverse());
            for(int i = 0; i < k * 2; i ++){
                Console.Write($"{row1[i] + row2[i]} ");
            }
            Console.WriteLine();
        }
    }
}
