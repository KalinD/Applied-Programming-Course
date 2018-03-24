using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam_Exam1_Problem3 {
    class Program {
        static void Main(string[] args) {
            int hour1 = int.Parse(Console.ReadLine());
            int minutes1 = int.Parse(Console.ReadLine());
            int hour2 = int.Parse(Console.ReadLine());
            int minutes2 = int.Parse(Console.ReadLine());
            if(hour1 > hour2){
                if(minutes1 >= minutes2 || hour1 - hour2 > 1){
                    int hour = hour1 - hour2 > 1 ? hour1 - hour2 - 1 : hour1 - hour2;
                    int minutes = hour1 - hour2 > 1 ? minutes1 + 60 - minutes2 : minutes1 - minutes2;
                    if(minutes >= 60){
                        hour++;
                        minutes %= 60;
                    }
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hour}:{(minutes).ToString("00")} hours before the start");
                }
                else{
                    if(minutes1 + 60 - minutes2 <= 30){
                        Console.WriteLine($"On time\n{minutes1 + 60 - minutes2} minutes before the start");
                    }
                    else {
                        Console.WriteLine($"Early\n{minutes1 + 60 - minutes2} minutes before the start");
                    }
                }
            }
            else if(hour2 > hour1){
                if(minutes2 >= minutes1){
                    Console.WriteLine($"Late\n{hour2 - hour1}:{(minutes2 - minutes1).ToString("00")} hours after the start");
                }
                else {
                    Console.WriteLine($"Late\n{minutes2 + 60 - minutes1} minutes after the start");
                }
            }
            else{
                if(minutes1 > minutes2) {
                    Console.WriteLine($"On time\n{minutes1 - minutes2} minutes before the start");
                }
                else if(minutes2 > minutes1) {
                    Console.WriteLine($"Late\n{minutes2 - minutes1} minutes after the start");
                }
                else{
                    Console.WriteLine("On time");
                }
            }
        }
    }
}
