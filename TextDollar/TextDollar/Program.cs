using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDollar                 //You are given a positive integer number. Print this out in english. NOTE: The correct spelling 
{                                    //output should be unspaced and in Camelcase(Pascal). Always assume plural dollars
    class Program                    //the numbers are < 1000000000 (1 billion).  In case of ambiguities 
    {                                          // e.g. 2200 could be TwoThousandTwoHundredDollars or TwentyTwoHundredDollars, 
        static void Main(string[] args)         //always choose the one with the larger base i.e. TwoThousandTwoHundredDollars
        {
            StringBuilder result = new StringBuilder();          //to print result 
            string line = "13000";                           
            int length = line.Length;                            //establish length of number
            double number;                                       //declaring some variables
            int num;            
            string numTeen;
            string linePass;
            if(length == 10)
            {
                Console.WriteLine("OneBillionDollars");         //Don't need this part, just wanted to print OneBillion
            }
            else if(length == 9)                                 //hundred millions
            {           
                Console.Write(HundredsConvert(line) + "Million");   //pass to hundreds place converter rmethod; add millions place
                linePass = line.Substring(line.Length - 6, 3);          //substring for 3 thousands places,
                Console.Write(ThousandsConvert(linePass));              // pass to thousands converter method
                linePass = line.Substring(line.Length - 3);             //substring for hundreds,tens, and ones places, 
                Console.WriteLine(HundredsConvert(linePass) + "Dollars");       //pass to hundreds method 
            }                                                                   //print final result with Dollars added
            else if (length == 8)                           //ten millions
            {
                number = Char.GetNumericValue(line[0]);     //convert from char to double
                num = Convert.ToInt32(number);              //convert from double to int      
                if (num == 1)                               //if starts with one, it is a special case, will need teen 
                {                                           //(i.e. 10, 11, 12, 13...) converter method
                    numTeen = Convert.ToString(line[line.Length - 2]) + Convert.ToString(line[line.Length - 1]);   //concatenate the 1 with the next number to get double digit value
                    int final = Convert.ToInt32(numTeen);               //convert from string to int
                    result.Append(TeensConvert(final) + "Million");     //pass this int to teen converter and add "million"
                    Console.Write(result);                               //print result
                }                                                       
                else
                {                                                         //otherwise proceed to convert 10 millions place
                    result.Append(TensConvert(num));
                    number = Char.GetNumericValue(line[1]);
                    num = Convert.ToInt32(number);
                    result.Append(OnesConvert(num) + "Million");            //convert 1 millions place, add "million"
                    Console.Write(result);                                   //print result
                }
                linePass = line.Substring(line.Length - 6, 3);              //thousands and hundreds convert methods
                Console.Write(ThousandsConvert(linePass));
                linePass = line.Substring(line.Length - 3);
                Console.WriteLine(HundredsConvert(linePass) + "Dollars");
            }
            else if (length == 7)                                             //1 millions
            {
                number = Char.GetNumericValue(line[0]);
                num = Convert.ToInt32(number);
                Console.Write(result.Append(OnesConvert(num) + "Million"));                
                linePass = line.Substring(line.Length - 6, 3);
                Console.Write(ThousandsConvert(linePass));
                linePass = line.Substring(line.Length - 3);
                Console.WriteLine(HundredsConvert(linePass) + "Dollars");
            } 
            else if(length == 6)                                              //100 thousands
            {    
                linePass = line.Substring(line.Length - 6, 3);
                Console.Write(ThousandsConvert(linePass));               
                linePass = line.Substring(line.Length - 3);
                Console.WriteLine(HundredsConvert(linePass) + "Dollars");

            }               
            else if(length == 5)                                             //10 thousands
            {
                number = Char.GetNumericValue(line[0]);
                num = Convert.ToInt32(number);
                if (num == 1)
                {
                    numTeen = Convert.ToString(line[0]) + Convert.ToString(line[1]);
                    int final = Convert.ToInt32(numTeen);
                    result.Append(TeensConvert(final)+ "Thousand");
                    Console.Write(result);
                }
                else
                {
                    result.Append(TensConvert(num));
                    number = Char.GetNumericValue(line[1]);
                    num = Convert.ToInt32(number);
                    result.Append(OnesConvert(num));
                    Console.Write(result + "Thousand");
                }
                linePass = line.Substring(line.Length - 3);
                Console.WriteLine(HundredsConvert(linePass) + "Dollars");
            }     
             else if (length == 4)                                            //1 thousands
            {
                number = Char.GetNumericValue(line[0]);
                num = Convert.ToInt32(number);                
                result.Append(OnesConvert(num) + "Thousand");
                Console.Write(result);              
                linePass = line.Substring(line.Length - 3);                
                Console.WriteLine(HundredsConvert(linePass) + "Dollars");                
            }     
            else if (length == 3)                                             //hundreds
            {
                Console.WriteLine(HundredsConvert(line)+ "Dollars");              
            }
            else if (length == 2)                                             //teens or tens
            {
                number = Char.GetNumericValue(line[0]);
                num = Convert.ToInt32(number);
                if (num == 1)
                {
                    numTeen = Convert.ToString(line[0]) + Convert.ToString(line[1]);
                    int final = Convert.ToInt32(numTeen);
                    result.Append(TeensConvert(final) + "Dollars");
                    Console.WriteLine(result);
                }
                else
                {                                                           
                    result.Append(TensConvert(num));
                    number = Char.GetNumericValue(line[1]);
                    num = Convert.ToInt32(number);
                    result.Append(OnesConvert(num) + "Dollars");
                    Console.WriteLine(result);
                }
            }
            else
            {                                                                 //ones
                number = Char.GetNumericValue(line[0]);
                num = Convert.ToInt32(number);
                result.Append(OnesConvert(num));
                Console.WriteLine(result + "Dollars");
            }
          
        }
        static string OnesConvert (int num)             //ones converter method with switch case
        {
            switch (num)
            {
                case 1:
                    return "One";                    
                case 2:
                    return "Two";                   
                case 3:
                    return "Three";                   
                case 4:
                    return "Four";                  
                case 5:
                    return "Five";                    
                case 6:
                    return "Six";                   
                case 7:
                    return "Seven";                    
                case 8:
                    return "Eight";                   
                case 9:
                    return "Nine";                    
                default:
                    return "";      
                    
            }
        }
        static string TeensConvert(int num)                 //teens converter method with switch case
        {
            switch (num)
            {
                case 10:
                    return "Ten";
                case 11:
                    return "Eleven";
                case 12:
                    return "Twelve";
                case 13:
                    return "Thirteen";
                case 14:
                    return "Fourteen";
                case 15:
                    return "Fifteen";
                case 16:
                    return "Sixteen";
                case 17:
                    return "Seventeen";
                case 18:
                    return "Eighteen";
                case 19:
                    return "Nineteen";
                default:
                    return "";
                    
            }
        }
        static string TensConvert(int num)                  //tens converter method with switch case
        {
            switch (num)
            {                
                case 1:
                    return "Ten";
                case 2:
                    return "Twenty";
                case 3:
                    return "Thirty";
                case 4:
                    return "Forty";
                case 5:
                    return "Fifty";
                case 6:
                    return "Sixty";
                case 7:
                    return "Seventy";
                case 8:
                    return "Eighty";
                case 9:
                    return "Ninety";
                default:
                    return "";
                   
            }
        }
        static string HundredsConvert(string line)        //to make a method for hundreds, 
        {                                                 //split off last 3 in longer numbers (line.SubString[length -3]).
            StringBuilder result = new StringBuilder();
            double number = Char.GetNumericValue(line[0]);     
            int num = Convert.ToInt32(number);                 
            if (num > 0)                 //if the number in the hundreds place is zero, we will skip the step(print nothing)
            {
                result.Append(OnesConvert(num) + "Hundred");    //ones converter on hundreds place               
            }                                                   //and add "Hundred"   to Stringbuilder
            number = Char.GetNumericValue(line[1]);             //tens place                               
            num = Convert.ToInt32(number);
                if (num == 1)                                   //check if number is a "teen", if so use teen converter method
            {
                    string numTeen = Convert.ToString(line[line.Length - 2]) + Convert.ToString(line[line.Length - 1]);
                    int final = Convert.ToInt32(numTeen);
                    result.Append(TeensConvert(final));            //add results to Stringbuilder
            }
                else if (num == 0 || num > 1)                      //otherwise use tens converter method
                {
                    result.Append(TensConvert(num));               //add results to StringBuilder
                    number = Char.GetNumericValue(line[2]);
                    num = Convert.ToInt32(number);                 //and ones converter method
                    result.Append(OnesConvert(num));               //add results to StringBuilder
            }            
            return result.ToString();                              //results to string and return
        }
        static string ThousandsConvert(string line)                 //thousands converter
        {
            StringBuilder result = new StringBuilder();             //declare variables;  need different variables for each
            double numberThree = Char.GetNumericValue(line[2]);     //index this time to account for cases of zeros
            int numThree = Convert.ToInt32(numberThree);
            double numberTwo = Char.GetNumericValue(line[1]);                                          
            int numTwo = Convert.ToInt32(numberTwo);
            double number = Char.GetNumericValue(line[0]);                 
            int num = Convert.ToInt32(number);                 
            if (num > 0)                                     //hundred thousands position; skip this step if number is zero
            {
                result.Append(OnesConvert(num) + "Hundred");    //use ones converter method and add hundred, 
            }                                                   //append to Stringbuilder
            if (numTwo == 1)                                    //ten thousands position; check for "teen"
            {
                string numTeen = Convert.ToString(line[line.Length - 2]) + Convert.ToString(line[line.Length - 1]);
                int final = Convert.ToInt32(numTeen);
                result.Append(TeensConvert(final));           // use teen converter method, append results to Stringbuilder
            }            
            else if (numTwo == 0 || numTwo > 1)                  //not a teen, use tens and ones converters 
            {                                                    //and append results to Stringbuilder
                result.Append(TensConvert(numTwo));
                result.Append(OnesConvert(numThree));
            }            
            if(num > 0 || numTwo >0|| numThree > 0)     //if all of the numbers in the thousands places were zero,
            {                                           //we wouldn't print "Thousand"; check to see if there is at 
                result.Append("Thousand");              //least one non-zero value in the thousands
            }                                           //if there is, append "Thousand" to Stringbuilder
            return result.ToString();                    //convert result to string and return it
        }
    }
}
