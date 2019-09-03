using System;
using System.Collections.Generic;
using System.Text;
using TransportPrice.Models;

namespace TransportPrice.Views {
    class Display {
        private int kilometers;
        private string dayNight;
        private PriceViewModel model;

        public int Kilometers { get => kilometers; set => kilometers = value; }
        public string DayNight { get => dayNight; set => dayNight = value; }
        public PriceViewModel Model { get => model; set => model = value; }

        public Display() {
            GetValues();
        }

        public void GetValues() {
            kilometers = int.Parse(Console.ReadLine());
            DayNight = Console.ReadLine();
        }

        public void PrintPrice() {
            Console.WriteLine(Model.Price);
        }
    }
}
