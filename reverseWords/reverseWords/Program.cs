using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello CodeEval say a little more";  //Reverse the words and print 
            string[] words = line.Split(' ');
            Array.Reverse(words);
            for(int i = 0; i < words.Length-1; i++)              //pretty straightforward
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine(words[words.Length - 1]);
        }
    }
}
