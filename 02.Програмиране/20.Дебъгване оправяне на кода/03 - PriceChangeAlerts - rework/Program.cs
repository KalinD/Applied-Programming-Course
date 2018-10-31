using System;

class PriceChangeAlert {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        double border = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++) {
            double current = double.Parse(Console.ReadLine());
            double difference = CalculateDifference(last, current);
            bool isThereADifference = IsThereADifference(difference, border);
            string message = GetMessage(current, last, difference, isThereADifference);
            Console.WriteLine(message);
            last = current;
        }
    }
    private static string GetMessage(double current, double last, double difference, bool isSignificantDifference) {
        string message = "";
        if (difference == 0) {
            message = string.Format("NO CHANGE: {0}", current);
        }
        else if (!isSignificantDifference) {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, current, difference);
        }
        else if (isSignificantDifference && (difference > 0)) {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, current, difference);
        }
        else if (isSignificantDifference && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, current, difference);
        return message;
    }
    private static bool IsThereADifference(double border, double isDiff) {
        if (Math.Abs(border) >= isDiff) {
            return true;
        }
        return false;
    }

    private static double CalculateDifference(double last, double current) {
        double difference = (current - last) / last;
        return difference * 100;
    }
}
