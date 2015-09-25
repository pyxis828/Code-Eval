using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findAWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg|" +
                " 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53";
            string[] split =line.Split('|');        //decode the string. The first part is the code
            string code = split[0];                  //stored in this variable string(from before the "|".
            string key = split[1].Trim();            //this variable string holds the decryption key(#'s)
            string[] listNum = key.Split(' ');       //Split the #'s & put the #'s into this array
            int length = listNum.Length;             //establish length of array and
            int [] lengthList = new int [length];     //set new int array to same length    
            for (int i=0; i< length; i ++)           //then move values from listNum into int array,        
            {                                               
                lengthList[i] = Convert.ToInt32(listNum[i]);     
            }
            foreach (int len in lengthList)         //print out the values at the INDEX in code
            {                                   
                Console.Write(code[len-1]);        
            }
            Console.WriteLine();
        }
    }
}
