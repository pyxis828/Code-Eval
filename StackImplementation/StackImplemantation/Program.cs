using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplemantation   //Write a program which implements a stack interface for integers. 
{                               //The interface should have ‘push’ and ‘pop’ functions. 
    class Program               //Your task is to ‘push’ a series of integers and then ‘pop’ and print every alternate integer.
    {                           // input 1 2 3 4 output 4 2
        static void Main(string[] args)
        {
            string line = "10 -2 4";                            //read line from file
            string[] nums = line.Split(' ');                    //split line along spaces and stor in an array
            Stack<string> numList = new Stack<string>();          
            foreach (string num in nums)                        //push the numbers from the array onto a stack
            {
                numList.Push(num);
            }
            {
            while (numList.Count > 0)                        //if stack is not empty, pop off top number and print
                Console.Write(numList.Pop() + " ");
                if (numList.Count > 0)                       //if stack is still not empty, pop off next value, but don't print
                {
                    numList.Pop();                          //continue until stack is empty
                }
            }
            Console.WriteLine();
        }
    }
}
