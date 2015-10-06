using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PrefixExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "* + 2 3 4";              //the expression to be evaluated
            string[] nums = line.Split(' ');        //split to array along spaces
            Array.Reverse(nums);                    //reverse the array -- proceed as with postfix expression
            Stack<string> numbers = new Stack<string>();    //declare some variables
            double operandTwo;
            double operandOne;
            string result = "";
            string convert;
            string final = ""; ;
            bool num;
            int i = 0;
            num = CheckForNumber(nums[i]);            //look for numbers method
            while (i < nums.Length)                   //loop within the string
            {
                if (num)                                    //if a number
                {                                                                                                              //convert from char to double                    
                    numbers.Push(nums[i]);                     // push to stack
                    i++;                                       //move to next index
                    num = CheckForNumber(nums[i]);       //check again for number 
                }
                else                                           //if not a number, it is an operator
                {
                    if (numbers.Count > 1)     //makes sure that the final number hasn't been calculated
                    {
                        operandTwo = Convert.ToDouble(numbers.Pop());           //pop out the last 2 numbers
                        operandOne = Convert.ToDouble(numbers.Pop());
                        result = OperandConvert(operandOne, operandTwo, nums[i]);   //do some math (method)
                        numbers.Push(result);                           //push that result to the stack
                    }
                    if (i < nums.Length - 1)                         //check for end of string
                    {
                        i++;                                            //increase index 
                        num = CheckForNumber(nums[i]);            //and check for number
                    }
                    else
                    {                               //if the end of the string is reached, there should 
                        final = numbers.Pop();      //be one number left in the stack; this is the answer                    
                        break;                      //pop it out and exit loop
                    }
                }
            }
            Console.WriteLine(final);               //print out the answer
        }
        static string OperandConvert(double numOne, double numTwo, string operation)
        {                             //method to do math, input 2 numbers from stack and the operator
            string result;
            if (operation == "+")
            {
                result = (numOne + numTwo).ToString();
                return result;
            }            
            else if (operation == "*")
            {
                result = (numOne * numTwo).ToString();
                return result;
            }
            else
            {
                result = (numOne / numTwo).ToString();
                return result;
            }
        }
        static bool CheckForNumber(string check)      //method to check for a number
        {            
            bool num = Regex.IsMatch(check, "\\d");
            return num;
        }
    }
}
