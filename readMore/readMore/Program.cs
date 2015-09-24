using System;                               //given a text.
using System.Collections.Generic;           // If line length is ≤ 55 characters
using System.Linq;                          // print it without any changes.
using System.Text;                          //If the line length is > 55 characters,
using System.Threading.Tasks;               //trim the line to 40 characters.
                                            //If there are spaces ‘ ’ in the resulting string
namespace readMore                          // trim it once again to the last space
{                                           //Add a string ‘... <Read More>’ 
    class Program                           //to the end of the resulting string and print it.

    {
        static void Main(string[] args)
        {
            string line = "Tom's mouth watered for the apple, but he stuck to his work.";
            string shortLine = "";
            string newLine = "";
            if (line.Length >= 55)
            {
                shortLine = line.Substring(0,39);  //if line is greater than 55 char, trim to 40
            }
            int trim = shortLine.LastIndexOf(' ');  //check for last space
            if (trim != -1)                                     //if there is a space
            {
                newLine = shortLine.Substring(0, trim);           //trim sentence at that spot
                Console.WriteLine(newLine + "... <Read More>");   //print out new line
            }
            else if(trim == -1)                                   //if text is one gigantic word
            {
                Console.WriteLine(shortLine = "... <Read More>"); //print it with Read More
            }
            else if (line.Length < 55)   //if the line is less than 55, leave it alone and print
            {
                Console.WriteLine(line);
            }
        }
    }
}
