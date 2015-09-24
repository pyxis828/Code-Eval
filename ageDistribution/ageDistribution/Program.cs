using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageDistribution                                       
{
    class Program
    {
        static void Main(string[] args)                         //given an input for age from 
        {                                                       //a file, print out the correct
            string line = "66";                                 //statement for that age.
            int age = int.Parse(line);      
            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (age >= 3 && age <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Elementary school");
            }
            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle school");
            }
            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High school");
            }
            else if (age >= 19 && age <= 22)
            {
                Console.WriteLine("College");
            }
            else if (age >= 23 && age <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if (age >= 66 && age <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans");
            }

            

        }
    }
}
