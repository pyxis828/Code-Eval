using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "496";          //Given a positive integer, 
            int length = line.Length;    //find the sum of its constituent digits.
            int sum = 0;
            int currentDigit = 0;
            for (int i=0; i < length; i++)
            {
                currentDigit = (int)Char.GetNumericValue(line[i]);
                sum += currentDigit;
            }
            Console.WriteLine(sum);        //Print out the sum  
        }                     
    }
}
