using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformation_from_array_to_int {
    class Program {
        static void Main(string[] args){
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length - 1];
            while (nums.Length > 1){
                condensed = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++){
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
