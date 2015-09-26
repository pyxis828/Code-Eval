using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitPositions                   //Given a number n and two integers p1,p2 
{                                        //determine if the bits in position p1 
    class Program                        //and p2 are the same or not. Positions p1 and p2 are 1 based.
    {                                    //List will contain a comma separated list of 3 integers.
        static void Main(string[] args)         //86,2,3 = true
        {
            string line = "925032,11,19";
            string[] split = line.Split(',');        //split list along the commas; put #'s into an array
            int num = int.Parse(split[0]);           //convert first element of array to integer number.
            int oneSpot = int.Parse(split[1]);       //convert 2nd two elements to integer numbers for bits
            int twoSpot = int.Parse(split[2]);       //convert num to binary
            string reverse = Convert.ToString(num, 2);  
            StringBuilder binary = new StringBuilder();     //binary numbers are read right to left, and will
            int length = reverse.Length - 1;                //need to be reversed before checking the bits
            for (int i = length; i >= 0; i--)               //done in this for loop and created in StringBuilder
                binary.Append(reverse[i]);
            int bitOne = binary[oneSpot - 1];         //set bitOne (p1) equal  to placement indicated by oneSpot 
            int bitTwo = binary[twoSpot - 1];         //subtract 1 to account for index value.  Repeat for bitTwo           
            if (bitOne == bitTwo)
            {
                Console.WriteLine("true");              //print out results;  unable to use bool value due to
            }                                           //output required to be lowercase.
            else
            {
                Console.WriteLine("false");
            }
          
        }
    }
}
