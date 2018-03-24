using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_for_element_in_sorted_array {
    class Program {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searched = int.Parse(Console.ReadLine());
            int r = 0, l = nums.Length - 1, m;
            m = (l + r) / 2;
            while (r + 1 != l){
                m = (l + r) / 2;
                if (nums[m] < searched){
                    r = m;
                }
                else if(nums[m] == searched){
                    Console.WriteLine("Yes");
                    break;
                }
                else
                {
                    l = m;
                }
            }
            if (nums[m] != searched){
                Console.WriteLine("No");
            }
        }
    }
}
