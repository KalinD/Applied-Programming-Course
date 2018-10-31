using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_same_neighboring_nums {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for(int i = 0; i < nums.Count - 1; i++) {
                if (nums[i] == nums[i + 1]){
                    int sum = nums[i] + nums[i + 1];
                    nums.RemoveAt(i);
                    nums.RemoveAt(i);
                    nums.Insert(i, sum);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
