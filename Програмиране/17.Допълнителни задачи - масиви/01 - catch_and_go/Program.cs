using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_and_go {
    class Program {
        static void Main(string[] args){
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            int index = nums.LastIndexOf(n);
            if(index != -1){
                int sum = 0;
                for (int i = 0; i < index; i++)
                {
                    sum += nums[i];
                }
                Console.WriteLine(sum);
            }
            else{
                Console.WriteLine("No occurences were found!");
            }
        }
    }
}
