using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace from_n_counting_system_to_dec {
    class Program {
        static void Main(string[] args) {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //nums[0] - counting system; nums[1] - number
            double result = 0;
            for (int i = 0; nums[1] > 0; i++) {
                result += nums[1] % 10 * Math.Pow(nums[0], i);
                nums[1] /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
