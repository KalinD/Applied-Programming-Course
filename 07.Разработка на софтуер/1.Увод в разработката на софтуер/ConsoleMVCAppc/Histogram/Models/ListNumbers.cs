using System;
using System.Collections.Generic;
using System.Text;

namespace Histogram.Models {
    class ListNumbers {
        private List<int> numbers;
        private List<double> percentages;

        public List<int> Numbers { get => numbers; set => numbers = value; }
        public List<double> Percentages { get => percentages; private set => percentages = value; }

        public ListNumbers() {
            Numbers = new List<int>();
            Percentages = new List<double>() { 0, 0, 0, 0, 0 };
        }

        public List<double> GetPercentages() {
            for(int i = 0; i < Numbers.Count; i++) {
                if(Numbers[i] < 200) {
                    Percentages[0]++;
                }
                else if(Numbers[i] <= 399) {
                    Percentages[1]++;
                }
                else if(Numbers[i] <= 599) {
                    Percentages[2]++;
                }
                else if(Numbers[i] <= 799) {
                    Percentages[3]++;
                }
                else {
                    Percentages[4]++;
                }
            }
            for(int i = 0; i < 5; i++) {
                Percentages[i] /= Numbers.Count;
                Percentages[i] *= 100;
            }
            return Percentages;
        }
    }
}
