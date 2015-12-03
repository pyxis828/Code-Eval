using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "1,1,3,3,8,8,9,9";            //You are given a sorted list of numbers with duplicates.
            string[] numList = line.Split(',');         //input sample list of sorted integers, comma delimited,                                                         
            int[] intList = new int[numList.Length];     //one per line. E.g. 1,1,1,2,2,3,3,4,4  
            intList = IntArrayConvert(numList);            //convert string arry to int array (uses method)
            Stack<int> unique = new Stack<int>();    
            StringBuilder result = new StringBuilder();
            unique.Push(intList[0]);                        //push first number to stack
            foreach(int num in intList)                     //loop through the list
            {
                if(unique.Peek() < num)                     //look for next (higher) number and push it to the stack
                {
                    unique.Push(num);
                }
            }
            List<int> backwards = new List<int>();
            while(unique.Count > 0)                         
            {
                backwards.Add(unique.Pop());              //pop the numbers off the stack and add them to a list
            }
            int[]final = new int[backwards.Count];
            final = backwards.ToArray();                 //convert the list to an array in order to call array reverse
            Array.Reverse(final);
            for(int i = 0; i <final.Length-1; i++)
            {
                result.Append(final[i] + ",");             //concatenate the numbers with commas
            }
            result.Append(final[final.Length - 1]);
            Console.WriteLine(result);                   //print the result
        }
        static int[] IntArrayConvert (params string[] numList)              //method to convert string array to int array
        {
            int[] intList = new int[numList.Length];
            int i = 0;
            foreach (string num in numList)
            {
               intList[i] = int.Parse(num);
                i++;
            }
            return intList;
        }   
    }
                                              
}                                                        