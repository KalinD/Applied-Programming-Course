using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Models {
    class Tip {
        private decimal amount;
        private double percent;

        public decimal Amount { get => amount; set => amount = value; }
        public double Percent {
            get => percent;
            set {
                if(value > 1) {
                    percent = value / 100.0;
                }
                else {
                    percent = (double)value;
                }
            }
        }

        public Tip() : this(0, 0) { }

        public Tip(decimal amount, double percent) {
            Amount = amount;
            Percent = percent;
        }

        public decimal CalculateTip() {
            return Amount * (decimal)Percent;
        }

        public decimal CalculateTotal() {
            return CalculateTip() + Amount;
        }
    }
}
