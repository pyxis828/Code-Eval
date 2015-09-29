using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrailingString            //There are two strings: A and B. 
                                    //Print 1 if string B occurs at the end of string A. Otherwise, print 0.
                                    //first argument is a path to the input filename containing 
                                    //two comma-delimited strings, one per line. 
                                    //I.E. Hello World,World 

{
    class Program
    {
        static void Main(string[] args)
        {
             string line = "Hello World,World";        
             string[] parts = line.Split(',');               //split line into an array at the comma
             string whole = parts[0];                        //string variable for part A, in first index of array
             string partial = parts[1];                      //string variable for part B, in second part of array
             int comparison = partial.Length;                //length of string to be compared
             int substring = whole.Length - comparison;      //gives index # of where to start comparing whole to partial                   
             if (substring >=0 && (whole.Substring(substring) == partial))   //compare end of part A to part B, and if equal
             {
                 Console.WriteLine(1);                    //print out 1                   
             }
             else                                        //if not equal
             {
                 Console.WriteLine(0);                   //print out 0                        
             }                
         }        
    }
}
