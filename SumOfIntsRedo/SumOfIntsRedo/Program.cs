using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntsRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "12";
            char[] splitters = new char[] { ' ' };
            string[] nums = line.Split(splitters);
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int current = int.Parse(nums[i]);
                sum += current;
            }
            Console.WriteLine(sum);
        }               
    }
}
