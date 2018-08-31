using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_with_car {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for(int i = 0; i < n; i++){
                //“<Модел> <КоличествоГориво> <РазходНаГоривоЗа1км>
                List<string> input = Console.ReadLine().Split().ToList();
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars[input[0]] = car;
            }
            while(true){
                List<string> command = Console.ReadLine().Split().ToList();
                if(command[0] == "End"){
                    break;
                }
                //Drive <МоделКола>  <бройКм>
                cars[command[1]].TryDriving(double.Parse(command[2]));
            }
            foreach(var car in cars){
                Console.WriteLine($"{car.Value.Model} {car.Value.GasAmount:f2} {car.Value.TraveledDistance}");
            }
        }
    }
}
