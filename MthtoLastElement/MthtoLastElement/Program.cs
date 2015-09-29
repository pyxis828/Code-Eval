using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MthtoLastElement          //Write a program which determines the Mth to the last element in a list.
{                                   // file contains the series of space delimited characters followed by 
    class Program                   //an integer. The integer represents an index in the list (1-based), one per line.
    {                               //Input = a b c d 4  Output = a.  If the index is larger than the number
        static void Main(string[] args)              //of elements in the list, ignore that input.
        {
            string line = "a b c d 5";          
            int split = line.LastIndexOf(' ');      //find last "space: to get index of where last entry (the number) starts
            string num = line.Substring(split);     //set a variable equal to the number and the extra space  
            num.TrimStart();                        //trim the extra space off                                 
            int index = int.Parse(num);             //convert string num to integer index number
            string letters = line.Remove(split);    //now get rid of the number from the back
            string[] listNums = letters.Split(' ');     //split the letters into an array
            int final = listNums.Length - index;        //set final index number -- needed for final if statement 
                if (final >= 0)                         //to avoid exceptions if index is larger than
            {                                           // number of items in list
                string result = listNums[final];        //get the indicated letter
                Console.WriteLine(result);              //print the result
                }                                      
        }
    }
}
