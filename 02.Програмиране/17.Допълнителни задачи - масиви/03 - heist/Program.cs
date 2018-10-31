using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heist {
    class Program {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int money = 0;
            string[] input = Console.ReadLine().Split(' ').ToArray();
            while(input[0] != "Jail" && input[1] != "Time"){
                money -= int.Parse(input[1]);
                for(int i = 0; i < input[0].Length; i++){
                    if(input[0][i] == '%'){
                        money += prices[0];
                    }
                    else if(input[0][i] == '$'){
                        money += prices[1];
                    }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            if(money >= 0){
                Console.WriteLine($"Heists will continue. Total earnings: {money}.");
            }
            else{
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(money)}.");
            }
        }
    }
}
