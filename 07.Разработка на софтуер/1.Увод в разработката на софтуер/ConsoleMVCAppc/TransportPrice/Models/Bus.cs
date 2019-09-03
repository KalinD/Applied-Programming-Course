namespace TransportPrice.Models {
    class Bus : Vehicle {
        private const double PRICE_PER_KM = 0.09;

        public Bus() : base(PRICE_PER_KM, PRICE_PER_KM){ }
    }
}
