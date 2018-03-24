using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip_Exam2_Problem3 {
    class Program {
        static void Main(string[] args) {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination;
            double price;
            string place;
            if(money <= 100){
                destination = "Bulgaria";
                if(season == "summer"){
                    price = money * 0.3;
                    place = "Camp";
                }
                else{
                    price = money * 0.7;
                    place = "Hotel";
                }
            }
            else if(money <= 1000){
                destination = "Balkans";
                if (season == "summer") {
                    price = money * 0.4;
                    place = "Camp";
                }
                else {
                    price = money * 0.8;
                    place = "Hotel";
                }
            }
            else{
                destination = "Europe";
                price = money * 0.9;
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}\n{place} - {price:f2}");
        }
    }
}
