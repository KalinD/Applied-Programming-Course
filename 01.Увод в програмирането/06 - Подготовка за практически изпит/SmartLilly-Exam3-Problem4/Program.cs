using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly_Exam3_Problem4 {
    class Program {
        static void Main(string[] args) {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double toy_price = double.Parse(Console.ReadLine());
            double money = 0;
            for(int i = 1; i <= age; i++){
                if(i % 2 == 0){
                    money += 5 * i;
                    money--;
                }
                else{
                    money += toy_price;
                }
            }
            if(money >= price){
                Console.WriteLine($"Yes! {money - price:f2}");
            }
            else{
                Console.WriteLine($"No! {price - money:f2}");
            }
        }
    }
}
