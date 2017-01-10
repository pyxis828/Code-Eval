using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "how am I supposed to skedaddledoo";
            string[] words = line.Split(' ');
            Console.WriteLine(printLongWord(words));
        }
        static string printLongWord(string[] words)
        {
            if (words.Length == 1)
            {
                return words[0];
            }
            else
            {
                int highIndex = 0;
                for (int i=0; i < words.Length-1; i++)
                {
                    for (int j=i+1; j < words.Length; j++)
                    {
                        if (words[j].Length > words[i].Length)
                        {
                            if (words[j].Length > words[highIndex].Length)
                            {
                                highIndex = j;
                            }
                            break;
                        }
                        else if (words[i].Length == words[j].Length)
                        {
                            break;
                        }
                        else
                        {
                            if (words[i].Length > words[highIndex].Length)
                            {
                                highIndex = i;
                            }
                            break;
                        }
                    }
                }
                return words[highIndex];
            }
        }
    }
}
