using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace difference_in_days {
    class DateModifier {
        public int DaysBetweenTwoDates(string date1, string date2){
            DateTime dateTime1 = new DateTime(int.Parse(date1.Split()[0]), int.Parse(date1.Split()[1]), int.Parse(date1.Split()[2]));
            DateTime dateTime2 = new DateTime(int.Parse(date2.Split()[0]), int.Parse(date2.Split()[1]), int.Parse(date2.Split()[2]));
            return Math.Abs((int)(dateTime1 - dateTime2).TotalDays);
        }
    }
}
