using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NModMwithoutMod       //Given two integers N and M, calculate N Mod M (without using any inbuilt modulus operator).
{                               //program should accept comma separated positive integers. E.g. 20,6  M will mot be zero
    class Program                                   //Print out the value of N Mod M
    {
        static void Main(string[] args)
        {
            string line = "26,2";
            string[] nums = line.Split(',');        //move numbers into string array, splitting at the comma
            int n = int.Parse(nums[0]);             //reassign array values as integers to the appropriate 
            int m = int.Parse(nums[1]);             //variables
            while (n - m >= 0)                       //instead of dividing, subtract M from N, until an amount
            {                                       // less than M remains, and this will be the remainder
                n -= m;
            }
            Console.WriteLine(n);               //print out the result
        }
    }
}
