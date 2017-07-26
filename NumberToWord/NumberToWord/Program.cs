using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    class Program
    {   
                 static void Main(string[] args)
                 { 
                   //pass in a number and ReturnAsString.changeToString will return it as a string
                    Console.WriteLine("what's the number");
                    int mynumber = Convert.ToInt32(Console.ReadLine());
                    if (mynumber == 0)
                    {
                     Console.Write("zero");
                    }
                    else
                    {
                    Console.Write(ReturnAsString.changeToString(mynumber));
                    }
                    Console.ReadLine();
                 }
    }
}

