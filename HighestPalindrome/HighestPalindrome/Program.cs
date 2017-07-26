using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            int highestPalindrome = 0;
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    int reverse = 0;
                    int myNumber = i * j;
                    int now = myNumber;
                    while (now != 0)
                    {//flip number
                        reverse = reverse * 10;
                        reverse += now % 10;
                        now = now / 10;
                    }
                    if (myNumber == reverse)
                    {

                        if (highestPalindrome < reverse)
                        {
                            highestPalindrome = reverse;
                        }
                    }
                }
            }
            Console.WriteLine(highestPalindrome);
            Console.ReadLine();
        }
    }
}


