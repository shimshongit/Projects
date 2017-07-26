using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finite
{//the algorithm can handle a grid much larger than it is just change the number's
    class playGame 
    {    //array of arrays is the grid true is alive false dead
        public static bool[,] grid = new bool[50,50];

        public static void play()
        {  //counter plus one for every alive neighbor
            int counter = 0;
            for (int i = 0; i < 50; i++)
            {//i is collumn j is row
                for (int j = 0; j < 50; j++)
                {
                    if (j != 0)//otherwise out of index of array
                    {
                        if (grid[i, j - 1] == true) //to the left of square
                        {
                            counter++;
                        }
                    }
                    if (j != 49)
                    {
                        if (grid[i, j + 1] == true)//right of square
                        {
                            counter++;
                        }
                    }
                    if (i != 0 && j != 0)
                    {
                        if (grid[i - 1, j - 1] == true)//above left
                        {
                            counter++;
                        }
                    }
                    if (i != 0)
                    {
                        if (grid[i - 1, j] == true)//above
                        {
                            counter++;
                        }
                    }
                    if (i != 0 && j != 49)
                    {
                        if (grid[i - 1, j + 1] == true)//above right
                        {
                            counter++;
                        }
                    }
                    if (i != 49 && j != 0)
                    {
                        if (grid[i + 1, j - 1] == true)//below left
                        {
                            counter++;
                        }
                    }
                    if (i != 49)
                    {
                        if (grid[i + 1, j] == true)//below
                        {
                            counter++;
                        }
                    }
                    if (i != 49 && j != 49)
                    {
                        if (grid[i + 1, j + 1] == true)//below right
                        {
                            counter++;
                        }
                    } 
                    if (grid[i, j] == false && counter == 3)//if sqare is dead with three live neighbors
                    {
                        grid[i, j] = true;
                    }
                    else if (grid[i, j] == true)//if grid is alive
                    {
                        if (counter < 2 || counter > 3)
                        {
                            grid[i, j] = false;
                        }
                    }
                    counter = 0;
                }

            }
        }
    }
}
