namespace TransportPrice.Models {
    class Taxi : Vehicle {
        private const double STARTING_PRICE = 0.7;
        private const double DAY_PRICE = 0.79;
        private const double NIGHT_PRICE = 0.9;

        public Taxi() : base(NIGHT_PRICE, DAY_PRICE){ }

        public override double GetPrice(int kilometers, string dayNight) {
            return base.GetPrice(kilometers, dayNight) + STARTING_PRICE;
        }
    }
}
