using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter a number for fizz:");
            // int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a number for buzz:");
            //  int y = int.Parse(Console.ReadLine());
            // Console.WriteLine("How high do you want to count?");
            //  int z = int.Parse(Console.ReadLine());
            string line = "3 5 10";  //some input value
            string[] nums = line.Split(' ');
            int x = int.Parse(nums[0]);                 //It's Fizz Buzz.  X for Fizz.  
            int y = int.Parse(nums[1]);                 //Y for Buzz. Z for how high to 
            int z = int.Parse(nums[2]);                 //count.  
            int i;
            
            for (i = 1; i < z; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.Write(" FB");
                }
                else if (i % x == 0)
                {
                    Console.Write(" F");
                }
                else if (i % y == 0)
                {
                    Console.Write(" B");
                }
                else
                {
                    Console.Write(" " + i);
                }
            }
            if (i == z)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine(" FB");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine(" F");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine(" B");
                }
                else
                {
                    Console.WriteLine(" " + i);
                }
            }
        }
    }
}
