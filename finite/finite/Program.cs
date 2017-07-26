using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finite
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            { //these for loops populate the grid with some true till now their all dead
                for (int j = 0; j < 50; j++)
                {
                    if (j % 2 == 0)
                    {
                        playGame.grid[i, j] = true;
                    }
                }
            }
            Console.WriteLine("How many generation's should we run on the grid");
            int howMany = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= howMany; i++)
            {
                playGame.play();
            }
            foreach (var row in playGame.grid)
            {
                if (row ==true)
                {
                    Console.Write("alive"+" ");
                }
                else
                {
                    Console.Write("dead"+" ");
                }
            }
            Console.ReadLine();

        }
    }
}
