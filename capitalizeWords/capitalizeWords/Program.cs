using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "hello world i need more words";           
            char[] ofLine = line.ToCharArray();
            char.ToUpper(ofLine[0], CultureInfo.CurrentCulture);
            int index = line.IndexOf(" ");
            while (index != -1)
            {
                char.ToUpper(ofLine[index + 1]);
                index = line.IndexOf(" ", index + 1);
            }
            for (int i= 0; i < ofLine.Length; i++)
            Console.Write(i);
            Console.WriteLine();
        }
    }

}
