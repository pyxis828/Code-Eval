using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "3992";           //convert to Roman Numerals a given number 
            int length = line.Length;       //from 1 - 3999
            int ones = 0;
            int tens= 0;                    //declare variables
            int hundreds= 0;
            int thousands = 0;
            if (length == 4)
            {
                 ones = (int)Char.GetNumericValue(line[3]);         //assign variables based on
                 tens = (int)Char.GetNumericValue(line[2]);         //length of number, digits
                 hundreds = (int)Char.GetNumericValue(line[1]);     //assigned to their 
                 thousands = (int)Char.GetNumericValue(line[0]);    //respective places. 
            }                                                       
            else if (length == 3)                                   
            {
                 ones = (int)Char.GetNumericValue(line[2]);
                 tens = (int)Char.GetNumericValue(line[1]);
                 hundreds =(int)Char.GetNumericValue(line[0]);
            }
            else if (length == 2)
            {
                 ones = (int)Char.GetNumericValue(line[1]);
                 tens = (int)Char.GetNumericValue(line[0]);
            }
            else if (length == 1)
            {
                 ones =(int)Char.GetNumericValue(line[0]);
            }
            switch (thousands)                     //assign Roman numeral to each digit.
            {                                      //Start with the thousands place since             
                case 1:                            //that will be read first (if the number
                    Console.Write("M");            //is that high).DO NOT CHANGE LINE!
                    break;
                case 2:
                    Console.Write("MM");
                    break;
                case 3:
                    Console.Write("MMM");
                    break;
                default:
                    break;
            }
            switch (hundreds)                   //Repeat for hundreds
            {
                case 1:
                    Console.Write("C");
                    break;
                case 2:
                    Console.Write("CC");
                    break;
                case 3:
                    Console.Write("CCC");
                    break;
                case 4:
                    Console.Write("CD");
                    break;
                case 5:
                    Console.Write("D");
                    break;
                case 6:
                    Console.Write("DC");
                    break;
                case 7:
                    Console.Write("DCC");
                    break;
                case 8:
                    Console.Write("DCCC");
                    break;
                case 9:
                    Console.Write("CM");
                    break;
                default:
                    break;
            }
            switch (tens)                       //Repeat for tens
            {
                case 1:
                    Console.Write("X");
                    break;
                case 2:
                    Console.Write("XX");
                    break;
                case 3:
                    Console.Write("XXX");
                    break;
                case 4:
                    Console.Write("XL");
                    break;
                case 5:
                    Console.Write("L");
                    break;
                case 6:
                    Console.Write("LX");
                    break;
                case 7:
                    Console.Write("LXX");
                    break;
                case 8:
                    Console.Write("LXXX");
                    break;
                case 9:
                    Console.Write("XC");
                    break;
                default:
                    break;
            }
            switch (ones)                         //Repeat for ones, adding to change line
            {
                case 1:
                    Console.WriteLine("I");
                    break;
                case 2:
                    Console.WriteLine("II");
                    break;
                case 3:
                    Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VII");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
                default:
                    break;
            }
         }   
    }
}
