using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseGroups                         //Given a list of numbers and a positive integer k, reverse the elements 
{                                               //of the list, k items at a time. If the number of elements is not a multiple
    class Program                               // of k, then the remaining items in the end should be left as is.
    {
        static void Main(string[] args)
        {
            string line = "1,2,3,4,5,6,7,8;3";
            string[] split = line.Split(';');               //split line into numbers list and number of items per group
            string numList = split[0];
            int index = int.Parse(split[1]);                //number of items per group
            string[] numbers = numList.Split(',');          //split numbers into an array
            int numGroups = numbers.Length / index;         //determine how may whole groups are in the list
            int arrayLength = numGroups * index;            //decalre an array of equal length to total of all whole groups
            string[] partial = new string[arrayLength];
            string[] final = new string[numbers.Length];    //final array will have ALL numbers
            int currentGroup = 1;
            int startIndex = 0;                             //index of first number in group
            int stopIndex = index;                          //index where next group starts
            while (currentGroup <= numGroups)               //perform reversing operations on each group
            {
                for (int i = startIndex; i < stopIndex; i++)        //move selected group into partial array
                {
                    partial[i] = numbers[i];
                }
                int j = startIndex;
                for (int i = stopIndex - 1; i >= startIndex; i--)   //reverse items of selected group
                {
                    final[j] = partial[i];
                    j++;
                }
                currentGroup++;                                     //move to next group
                startIndex += index;
                stopIndex = index * currentGroup;
            }                   
            for (int i = startIndex; i < final.Length; i++)         //add any numbers which were not part of a group
            {                                                       //to the end of the array
                final[i] = numbers[i];
            }
            for (int i=0; i < final.Length -1; i++)                 //loop through array, print out results seperated
            {                                                       //by commas
                Console.Write(final[i] + ",");
            }
            Console.WriteLine(final[final.Length - 1]);             //print last number in array with no comma after it
        }
    }
}
