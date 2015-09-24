using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCharacters                      //input: string w/characters that need to be scrubbed.
{                                              // Each source string and characters you need 
    class Program                               //to scrub are delimited by comma. output:
    {                                           //crubbed strings, one per line. 
        static void Main(string[] args)         //Ensure that there are no trailing empty spaces
        {
            string line = "how are you, abc";
            int splice = line.IndexOf(",");
            string sentence = line.Substring(0, splice);
            string withComma = line.Substring(splice);
            char[] noComma = { ' ', ',' };
            string removals = withComma.Trim(noComma);
            int length = removals.Length;         
            char[] trimmers = removals.ToCharArray(0, length);
            Console.WriteLine(sentence.Trim(trimmers));
        }
    }
}
