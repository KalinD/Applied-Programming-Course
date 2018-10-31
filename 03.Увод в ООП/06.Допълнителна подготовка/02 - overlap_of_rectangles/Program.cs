using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overlap_of_rectangles {
    class Program {
        static void Main(string[] args) {
            List<int> amounts = Console.ReadLine().Split().Select(int.Parse).ToList();
            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();
            for (int i = 0; i < amounts[0]; i++){
                List<string> input = Console.ReadLine().Split().ToList();
                Rectangle rectangle = new Rectangle(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4]));
                rectangles[input[0]] = rectangle;
            }
            for (int i = 0; i < amounts[1]; i++) {
                string toCompare = Console.ReadLine();
                //to remove the upper case in True and False
                Console.WriteLine(rectangles[toCompare.Split()[0]].ColisionCheck(rectangles[toCompare.Split()[1]]) == true ? "true" : "false");
            }
        }
    }
}
