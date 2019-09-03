using System;
using System.Collections.Generic;
using System.Text;

namespace OnTimeForExam.Models {
    class Student {
        private TimeSpan arrivalTime;
        private TimeSpan examTime;

        public TimeSpan ArrivaTime { get => arrivalTime; set => arrivalTime = value; }
        public TimeSpan ExamTime { get => examTime; set => examTime = value; }

        public string GetOutputString() {
            TimeSpan difference = arrivalTime.Subtract(examTime);
            int minutes = difference.Minutes + difference.Hours * 60;
            if(minutes > 0) {
                if(minutes <= 30) {
                    return $"On time\n{minutes} minutes before the start";
                }
                if(minutes >= 60) {
                    return $"Early\n{minutes / 60}:{minutes % 60:00} hours before the start";
                }
                return $"Early\n{minutes} minutes before the start";
            }
            else if(minutes == 0) {
                return $"On time";
            }
            else {
                minutes = Math.Abs(minutes);
                if(minutes >= 60) {
                    return $"Late\n{minutes / 60}:{minutes % 60:00} hours after the start";
                }
                return $"Late\n{minutes} minutes after the start";
            }
        }
    }
}
