using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_around {
    class Program {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = 0;
            int sum = 0;
            while(index >= 0 && index < nums.Count){
                sum += nums[index];
                if(index + nums[index] >= nums.Count){
                    index -= nums[index];
                }
                else{
                    index += nums[index];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
