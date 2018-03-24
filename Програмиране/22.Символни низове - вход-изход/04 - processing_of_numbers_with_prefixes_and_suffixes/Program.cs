using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processing_of_numbers_with_prefixes_and_suffixes {
    class Program {
        static void Main(string[] args) {
            List<string> nums = Console.ReadLine().Split(' ').ToList();
            double sum = 0;
            for(int i = 0; i < nums.Count; i++){
                char letter1 = nums[i][0];
                char letter2 = nums[i][nums[i].Length - 1];
                double num = 0;
                int j = 1;
                while(j < nums[i].Length - 1) {
                    num = num * 10.0 + (int)nums[i][j] - '0';
                    j++;
                }
                if(letter1.ToString() == letter1.ToString().ToUpper()){
                    num /= letter1 - 'A' + 1;
                }
                else{
                    num *= letter1 - 'a' + 1;
                }
                if (letter2.ToString() == letter2.ToString().ToUpper()) {
                    num -= letter2 - 'A' + 1;
                }
                else {
                    num += letter2 - 'a' + 1;
                }
                sum += num;
            }
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
