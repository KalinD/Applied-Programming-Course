using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raw_data {
    class Program {
        static void Main(string[] args) {
            //<Модел> <СкоростНаДвигателя> <МощностнаДвигателя> <ТеглоНаТовара> <ТипНаТовара> <Гума1Налягане> <Гума1Възраст> <Гума2Налягане> <Гума2Възраст> <Гума3Налягане> <Гума3Възраст> <Гума4Налягане> <Гума4Възраст>” 
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for(int i = 0; i < n; i++){
                List<string> data = Console.ReadLine().Split(' ').ToList();
                Model model = new Model(data[0]);
                Car car = new Car(model, int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), data[4], double.Parse(data[5]), double.Parse(data[6]), double.Parse(data[7]), double.Parse(data[8]), double.Parse(data[9]), double.Parse(data[10]), double.Parse(data[11]), double.Parse(data[12]));
                cars.Add(car);
            }
            string type = Console.ReadLine();
            foreach(Car car in cars){
                if(type == car.GetLoadType() && type == "fragile" && car.SmallPressure()){
                    Console.WriteLine(car.GetModel());
                }
                if (type == car.GetLoadType() && type == "flamable" && car.BigPower()) {
                    Console.WriteLine(car.GetModel());
                }

            }
        }
    }
}
