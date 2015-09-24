using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenultimateWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "another line";
            string[] str = line.Split(' ');
            int length = str.Length;
            Console.WriteLine(str[length - 2]);

        }
    }
}
