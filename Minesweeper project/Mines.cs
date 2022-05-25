using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_project
{
    internal class Mines 
    {
        public static int[,] plantBombs()
        {
            Random r = new Random();

            int[,] grid = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grid[i, j] = 0;

                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grid[i, j] = 4;

                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int positioni = r.Next(10);
                    int positionj = r.Next(10);
                    int saved = grid[i, j];
                    grid[i, j] = grid[positioni, positionj];
                    grid[positioni, positionj] = saved;


                }

            }
            return grid;
        }
    }
}




