using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom_Exam5_Problem3 {
    class Program {
        static void Main(string[] args) {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            if (month == "May" || month == "October") {
                studio = days * 50;
                apartment = days * 65;
                if (days > 14) {
                    studio -= (studio * 30) / 100;
                }
                else if (days > 7) {
                    studio -= studio / 20;
                }
            }
            else if (month == "June" || month == "September") {
                studio = days * 75.2;
                apartment = days * 68.7;
                if (days > 14) {
                    studio -= studio / 5;
                }
            }
            else {
                studio = days * 76;
                apartment = days * 77;
            }
            if (days > 14) {
                apartment -= apartment / 10;
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv\nStudio: {studio:f2} lv");
        }
    }
}
