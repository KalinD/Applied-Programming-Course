using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes_Exam2_Problem2 {
    class Program {
        static void Main(string[] args) {
            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double together = p1 * hours + p2 * hours;
            if(together <= volume){
                Console.WriteLine($"The pool is {Math.Truncate((together / volume) * 100)}% full. Pipe 1: {Math.Truncate((p1 * hours / together) * 100)}%. Pipe 2: {Math.Truncate((p2 * hours / together) * 100)}%.");
            }
            else{
                Console.WriteLine($"For {hours} hours the pool overflows with {together - volume} liters.");
            }
        }
    }
}
