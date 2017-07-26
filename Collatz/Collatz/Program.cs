using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {   
            for (int i = 1; i < 1000000; i++)
            {
                LongestChain(i);
               
                if (counter > lengthOfChain)
                {   //save number of steps in length of chain and the number in my number for longest sequence 
                    lengthOfChain = counter;
                    myNumber = i;
                }
                    counter = 0;
            }
            Console.WriteLine(myNumber);
            Console.WriteLine(lengthOfChain);
            Console.ReadLine();
        }
        static int counter = 0;
        static int lengthOfChain = 0;
        static int myNumber = 0;

        static void LongestChain(long j)
        {//perform collatz sequence
            if (j > 1)
            {
                if (j % 2 == 0)
                {
                    j = j / 2;
                }
                else
                {
                    j = j * 3 + 1;
                }
                counter++;
                LongestChain(j);
            }
        }
    }
}
