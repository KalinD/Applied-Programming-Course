using ConsoleMVC.Models;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Controllers {
    class TipCalculatorController {
        private Display display;
        private Tip tip;

        internal Tip Tip { get => tip; set => tip = value; }
        internal Display Display { get => display; set => display = value; }

        public TipCalculatorController() {
            Display = new Display();
            Tip = new Tip();
        }

        public void CalculateTotal() { 
            Display.GetValues();

            Tip.Amount = Display.Amount;
            Tip.Percent = Display.Percent;

            Display.TipAmount = Tip.CalculateTip();
            Display.Total = Tip.CalculateTotal();

            Display.ShowTipAndTotal();
        }
    }
}
