using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTheNumber                        //You are given a number N and a pattern. The pattern consists of
                                                //lowercase latin letters and one operation "+" or "-". 
{                                               //The challenge is to split the number and evaluate it according to this pattern e.g.
    class Program                               //1232 ab+cd -> a:1, b:2, c:3, d:2 -> 12+32 -> 44
    {
        static void Main(string[] args)
        {
            string line = "90602 a+bcde";
            string[] split = line.Split(' ');
            string number = split[0];
            string pattern = split[1];
            char operand = ' ';
            int index = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                if(pattern[i] == '+' || pattern[i] == '-')
                {
                    operand = pattern[i];
                    index = i;
                    break;                    
                }               
            }
            string numOne = number.Substring(0, index);
            string numTwo = number.Substring(index );
            int numberOne = Convert.ToInt32(numOne);
            int numberTwo = Convert.ToInt32(numTwo);
            int result = doMath(numberOne, numberTwo, operand);
            Console.WriteLine(result);
        }
        static int doMath(int numberOne, int numberTwo, char operand)
        {
            int result;
            if(operand == '+')
            {
                result = numberOne + numberTwo;
            }
            else
            {
                result = numberOne - numberTwo;
            }
            return result;
        }
    }
}
