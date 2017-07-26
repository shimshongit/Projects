using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicableNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int amicableNumbers = 0;
            int[] properDivisors = new int[10000];
            //add up the sum of proper divisors and put it in that number place in array
            for (int i = 0; i < 10000; i++)
            {
                int counter = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        counter += j;
                    }
                }
                properDivisors[i] = counter;
            }
            for (int i = 0; i < 10000; i++)
            {   //some proper divisor's equal the number their being divided from
                if (properDivisors[i] != i)
                {
                    if (properDivisors[i] < 10000)
                    {    //if the number in index i's index in the array equal's i 
                        if (i == properDivisors[properDivisors[i]])
                        {
                            amicableNumbers += i;
                        }
                    }
                }
            }
            Console.WriteLine(amicableNumbers);
            Console.ReadLine();
        }  
    }
}
