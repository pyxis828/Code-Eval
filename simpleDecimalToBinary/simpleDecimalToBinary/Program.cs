using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "10";
            int num = int.Parse(line);
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(binary); 
        }
    }
}
