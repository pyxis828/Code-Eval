using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightmostChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "no value,m";
            string[] words = line.Split(',');
            string final = (words[0]);
            char indexer = Convert.ToChar(words[1]);
            int rightmost = final.LastIndexOf(indexer);
            Console.WriteLine(rightmost);
            

        }
    }
}
