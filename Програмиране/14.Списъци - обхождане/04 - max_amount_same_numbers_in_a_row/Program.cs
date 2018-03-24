using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_amount_same_numbers_in_a_row {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1, max = count;
            for (int i = 0; i < nums.Count - 1; i++){
                if(nums[i] == nums[i + 1]){
                    count++;
                }
                else{
                    count = 1;
                }
                max = Math.Max(count, max);
            }
            count = 1;
            for (int i = 0; i < nums.Count - 1; i++) {
                if (nums[i] == nums[i + 1]) {
                    count++;
                    if(count == max){
                        while(max > 0){
                            Console.Write($"{nums[i]} ");
                            max--;
                        }
                        break;
                    }
                }
                else {
                    count = 1;
                }
            }
        }
    }
}
