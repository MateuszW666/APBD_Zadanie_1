using System;

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            double average = CalculateAverage(numbers);
            Console.WriteLine($"Średnia: {average}");
            //znajdowanie max wartosci zad 3
            int max = FindMaxValue(numbers);
            Console.WriteLine($"Maksymalna wartość: {max}");
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


