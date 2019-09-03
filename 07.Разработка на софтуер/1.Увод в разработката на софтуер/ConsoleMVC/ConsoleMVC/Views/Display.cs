using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Views {
    class Display {
        private decimal amount;
        private double percent;
        private decimal total;
        private decimal tipAmount;

        public decimal Amount { get => amount; set => amount = value; }
        public double Percent { get => percent; set => percent = value; }
        public decimal Total { get => total; set => total = value; }
        public decimal TipAmount { get => tipAmount; set => tipAmount = value; }

        public Display() {
            Amount = 0;
            Percent = 0;
            Total = 0;
            TipAmount = 0;
        }

        public void GetValues() {
            Console.WriteLine("Enter the amount of the meal:");
            Amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent you want to tip:");
            Percent = double.Parse(Console.ReadLine());
        }

        public void ShowTipAndTotal() {
            Console.WriteLine($"Your tip is: {TipAmount:N}");
            Console.WriteLine($"The total will be {Total:N}");
        }
    }
}
