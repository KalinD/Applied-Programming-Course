using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot_s_route {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            StringBuilder commands = new StringBuilder(input.Length);
            commands.Append(input);
            int angle = 0;
            int x = 0;
            int y = 0;
            //angle = 0 - right; angle = 90 - up; angle = 180 - left ; angle = 270 - down
            for (int i = 0; i < input.Length; i++){
                if(commands[i] == 'R'){
                    angle -= 90;
                    if(angle < 0){
                        angle = 270;
                    }
                }
                else if(commands[i] == 'L'){
                    angle += 90;
                    if(angle > 270){
                        angle = 0;
                    }
                }
                else{
                    int movement = 0;
                    for(; i < commands.ToString().Length && (commands[i] != 'R' && commands[i] != 'L'); i++){
                        movement = movement * 10 + (commands[i] - '0');
                    }
                    i--;
                    switch (angle) {
                        case 0:
                            x += movement;
                            break;
                        case 90:
                            y += movement;
                            break;
                        case 180:
                            x -= movement;
                            break;
                        case 270:
                            y -= movement;
                            break;
                    }
                }
            }
            Console.WriteLine($"Position: (x:{x}, y:{y}), Distance = {Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)):f2} m");
        }
    }
}
