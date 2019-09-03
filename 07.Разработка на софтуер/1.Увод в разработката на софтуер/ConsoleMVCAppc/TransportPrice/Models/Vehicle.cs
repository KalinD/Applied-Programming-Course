namespace TransportPrice.Models {
    public abstract class Vehicle {
        private double nightRate;
        private double dayRate;

        public double NightRate { get => nightRate; set => nightRate = value; }
        public double DayRate { get => dayRate; set => dayRate = value; }


        public Vehicle(double nightRate, double dayRate) {
            NightRate = nightRate;
            DayRate = dayRate;
        }
        public virtual double GetPrice(int kilometers, string dayNight) {
            if(dayNight == "day") {
                return kilometers * DayRate;
            }
            return kilometers * NightRate;        
        }
    }
}
