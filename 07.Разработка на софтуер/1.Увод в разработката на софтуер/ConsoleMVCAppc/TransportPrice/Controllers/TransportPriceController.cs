using TransportPrice.Models;
using TransportPrice.Views;

namespace TransportPrice {
    class TransportPriceController {
        private Display display;
        private Vehicle vehicle;

        internal Display Display { get => display; set => display = value; }
        internal Vehicle Vehicle { get => vehicle; set => vehicle = value; }

        public TransportPriceController() {
            Display = new Display();
        }

        public void Start() {
            int kilometers = Display.Kilometers;
            string dayNight = Display.DayNight;
            if(kilometers < 20) {
                Vehicle = new Taxi();
            }
            else if(kilometers < 100) {
                Vehicle = new Bus();
            }
            else {
                Vehicle = new Train();
            }
            double price = Vehicle.GetPrice(kilometers, dayNight);
            Display.Model = new PriceViewModel(price);
            Display.PrintPrice();
        }
    }
}
