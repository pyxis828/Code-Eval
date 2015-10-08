using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordtoDigit                                           //input = zero;two;five;seven;eight;four output = 02578
{                                                               // numbers are zero to nine
    class Program
    {
        static void Main(string[] args)
        {
            string line = "zero;two;five;seven;eight;four";
            string [] words = line.Split(';');
            Dictionary<string, int> numbers = new Dictionary<string, int>();
            numbers.Add("zero", 0);
            numbers.Add("one", 1);
            numbers.Add("two", 2);
            numbers.Add("three", 3);
            numbers.Add("four", 4);
            numbers.Add("five", 5);
            numbers.Add("six", 6);
            numbers.Add("seven", 7);
            numbers.Add("eight", 8);
            numbers.Add("nine", 9);
            foreach (string word in words)
            {
                int digit = numbers[word];
                Console.Write(digit);                
            }
            Console.WriteLine();
        }
    }
}
