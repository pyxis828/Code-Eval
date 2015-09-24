using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSort_Reboot   //Print sorted numbers to the 3rd digit after the dot including trailing zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "70.920 -38.797 14.354 99.323 90.374 7.581";
            string [] nums = line.Split(' ');
            int length = nums.Length;
            double[] decimals = new double[length];
            string sorted = "";
            for (int i = 0; i < length; i++)
            {
                decimals[i] = double.Parse(nums[i]);
            }
            Array.Sort(decimals);
            for (int i = 0; i < length-1; i++)
            {
                sorted = decimals[i].ToString("#.000 ");
                Console.Write(sorted);
            }
            for (int i = length-1; i < length; i++)
            {
                sorted = decimals[i].ToString("#.000");
                Console.WriteLine(sorted);
            }
        }
    }
}
