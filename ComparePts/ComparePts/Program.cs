using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparePts                                //Bob (the idiot) is forever lost in woods.
{                                                   //Compare 2 points to determine which
    class Program                                   //compass direction Bob needs to go to
    {                                               //get to camp (i.e NE, S, SW, etc.).
            static void Main(string[] args)         //Points given are in format (O, P),(Q, R).
        {                                            
            string line = "0 1 0 5";
            string[] points = line.Split(' ');      
            int O = int.Parse(points[0]);           //assign type int variables to each
            int P = int.Parse(points[1]);           //coordinate.
            int Q = int.Parse(points[2]);
            int R = int.Parse(points[3]);
            if(R==P && Q == O)                      //extra dumb and lost at camp; otherwise
            {
                Console.WriteLine("here");
            }
            if (R > P)                              //begin by comparing Y coordinates
            {                                       //R and P to determine whether to go
                Console.Write("N");                 //North or South (as y axis compares
            }                                       //relatively to N/S).  Do this first
            else                                    //because when we say directions, N/S
            {                                       //is said first before E/W.
                if (R < P)
                {
                    Console.Write("S");
                }
                else if (R == P)                    //prints nothing if no N/S direction 
                {                                   //is needed.
                    Console.Write("");
                }
            }
            if (Q > O)                              //repeat for x coordinates and E/W
            {
                Console.WriteLine("E");
            }
            else
            {
                if (Q < O)
                {
                    Console.WriteLine("W");
                }
                else if (Q == O)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
