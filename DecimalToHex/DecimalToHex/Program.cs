using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "9f";
            int num = Convert.ToInt32(line, 16);
            Console.WriteLine(num);
        }
    }
}
