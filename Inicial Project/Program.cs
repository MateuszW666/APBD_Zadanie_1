using System;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(numbers);
            Console.WriteLine($"Średnia: {average}");
        }

        static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }
    }
}

