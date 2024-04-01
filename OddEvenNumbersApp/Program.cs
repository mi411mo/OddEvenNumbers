using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumbersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumbers(numbers);
            PrintNumbers(numbers.Where(n => IsEven(n)));
            PrintNumbers(numbers.Where(n => IsOdd(n)));
        }

        static void PrintNumbers(IEnumerable<int> numbers)
        {
            Console.WriteLine($"\n[ { string.Join(", ", numbers) } ]");
        }

        static bool IsEven(int num) => num % 2 == 0;
        
        static bool IsOdd(int num) => !IsEven(num);
    }
}