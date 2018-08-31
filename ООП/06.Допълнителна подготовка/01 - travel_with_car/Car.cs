using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_with_car {
    class Car {
        //модела, количеството гориво, разхода на гориво за 1 км. и пропътуваното разстояние
        private string model;
        private double gasAmount;
        private double gasUsage;
        private double traveledDistance;
        public string Model{
            get{
                return model;
            }
            set{
                model = value;
            }
        }
        public double GasAmount {
            get {
                return gasAmount;
            }
            set {
                gasAmount = value;
            }
        }
        public double GasUsage {
            get {
                return gasUsage;
            }
            set {
                gasUsage = value;
            }
        }
        public double TraveledDistance {
            get {
                return traveledDistance;
            }
            set {
                traveledDistance = value;
            }
        }
        public Car(string model, double gasAmount, double gasUsage){
            this.model = model;
            this.gasAmount = gasAmount;
            this.gasUsage = gasUsage;
            this.traveledDistance = 0;
        }
        public void TryDriving(double distance){
            double possibleDistance = gasAmount / gasUsage;
            if(distance > possibleDistance){
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else{
                gasAmount -= distance * gasUsage;
                traveledDistance += distance;
            }
        }
    }
}
