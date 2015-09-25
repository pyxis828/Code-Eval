using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "1023";
            int num = int.Parse(line);
            string binary = "";
            while (num>0)
            {               
                binary += Convert.ToString(num % 2);
                num /= 2;
            }
            int length = binary.Length - 1;
            for (int i = length ; i >= 0; i--)
                {
                    Console.Write(binary[i]);
                }
            Console.WriteLine();
        }
    }
}
