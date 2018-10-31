using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_seller {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for(int i = 0; i < n; i++){
                //“<Model> <Power> <Displacement>* <Efficiency>*
                List<string> input = Console.ReadLine().Split().ToList();
                Engine engine = new Engine(input[0], double.Parse(input[1]));
                if(input.Count >= 3){
                    try{
                        engine.Displacement = double.Parse(input[2]);
                    }
                    catch(Exception){
                        engine.Efficiency = input[2];
                    }
                }
                if(input.Count > 3){
                    engine.Efficiency = input[3];
                }
                engines.Add(engine);
            }
            n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++) {
                //<Model> <Engine> <Weight>* <Color>*
                List<string> input = Console.ReadLine().Split().ToList();
                Car car = new Car();
                car.Model = input[0];
                foreach(Engine engine in engines){
                    if(engine.Model == input[1]){
                        car.EngineType = engine;
                        break;
                    }
                }
                if (input.Count >= 3) {
                    try {
                        car.Weight = double.Parse(input[2]);
                    }
                    catch (Exception) {
                        car.Color = input[2];
                    }
                }
                if (input.Count > 3) {
                    car.Color = input[3];
                }
                cars.Add(car);
            }

            foreach(Car car in cars){
                Console.WriteLine(car.ToString());
            }
        }
    }
}
