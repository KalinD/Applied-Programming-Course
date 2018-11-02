using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raw_data {
    class Car {
        private Model model; //“<Модел> 
        private int[] engine; //<СкоростНаДвигателя> <МощностнаДвигателя> 
        private Load load; //<ТеглоНаТовара> <ТипНаТовара> 
        private double[] wheels; //<Гума1Налягане> <Гума1Възраст> <Гума2Налягане> <Гума2Възраст> <Гума3Налягане> <Гума3Възраст> <Гума4Налягане> <Гума4Възраст>
        public Car(Model model, int speed, int power, int weight, string type,  double pressure1, double age1, double pressure2, double age2, double pressure3, double age3, double pressure4, double age4) {
            this.model = model;
            engine = new int[2];
            engine[0] = speed;
            engine[1] = power;
            load = new Load(weight, type);
            wheels = new double[8];
            wheels[0] = pressure1;
            wheels[1] = age1;
            wheels[2] = pressure2;
            wheels[3] = age2;
            wheels[4] = pressure3;
            wheels[5] = age3;
            wheels[6] = pressure4;
            wheels[7] = age4;
        }

        public string GetLoadType(){
            return load.Type;           
        }

        public Boolean SmallPressure(){
            for(int i = 0; i < 8; i += 2){
                if(wheels[i] < 1){
                    return true;
                }
            }
            return false;
        }

        public string GetModel(){
            return model.Name;
        }

        public Boolean BigPower() {
            for (int i = 0; i < 8; i += 2) {
                if (engine[1] > 250) {
                    return true;
                }
            }
            return false;
        }
    }
}
