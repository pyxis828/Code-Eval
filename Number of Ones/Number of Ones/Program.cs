using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Ones                    //Write a program which determines the number of 
{                                           //1 bits in the internal representation of a given integer.
    class Program
    {
        static void Main(string[] args)
        {
            string line = "828";
            int num = int.Parse(line);                  //convert string to int, so that I can
            string binary = Convert.ToString(num, 2);   //turn it back to a string, only in binary this time.
            int numOnes = 0;                            //declare counter variable
            foreach (char bit in binary)                //run a loop over the binary string
            {                
                if (bit == 49)                          //check for char value of 1 
                {
                    numOnes += 1;                       //if present, increase counter by 1
                }
            }
            Console.WriteLine(numOnes);                 //print final tally
        }
    }
}
