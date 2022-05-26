using System;

namespace Minesweeper_project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] grid = Mines.plantBombs();

            int[,] userGrid = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {


                    int col = i;
                    int row = j;
                    userGrid[row, col] = grid[i, j];
                }

            }


            void addingNumbers(int row, int col)
            {

                int minesNearBy;

                for (int count = 0; count < 90; count++)
                {


                    if (CheckCoordinateValidity.isValid(row - 1, col - 1) == true && userGrid[row - 1, col - 1] == 0)
                    {

                        count++;

                    }


                    if (CheckCoordinateValidity.isValid(row - 1, col) == true && userGrid[row - 1, col] == 0)
                    {
                        count++;
                    }


                    if (CheckCoordinateValidity.isValid(row - 1, col + 1) == true && userGrid[row - 1, col + 1] == 0)
                    {

                        count++;

                    }

                    if (CheckCoordinateValidity.isValid(row, col - 1) == true && userGrid[row, col - 1] == 0)
                    {

                        count++;

                    }

                    if (CheckCoordinateValidity.isValid(row, col + 1) == true && userGrid[row, col + 1] == 0)
                    {

                        count++;

                    }

                    if (CheckCoordinateValidity.isValid(row + 1, col - 1) == true && userGrid[row + 1, col - 1] == 0)
                    {

                        count++;
                    }

                    if (CheckCoordinateValidity.isValid(row + 1, col) == true && userGrid[row + 1, col] == 0)
                    {

                        count++;
                    }


                    if (CheckCoordinateValidity.isValid(row + 1, col + 1) == true && userGrid[row + 1, col + 1] == 0)
                    {

                        count++;
                    }


                    minesNearBy = count;

                    Console.WriteLine("Be careful! There are " + minesNearBy + " bombs near you");
                    break;

                }
                Console.WriteLine();

            }


            int RowCoord;
            int ColumnCoord;


            UserIntro.UserIntroduction();

            int GuessesToWin = 90;
            int guess;
            for (guess = 0; guess < GuessesToWin; guess++)
            {

                Console.WriteLine("Pick your row coordinate");
                RowCoord = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick your column coordinate");
                ColumnCoord = int.Parse(Console.ReadLine());

                if (userGrid[RowCoord, ColumnCoord] == 0)
                {
                    Console.WriteLine("Boom!");
                    Console.WriteLine("Game Over");
                    break;
                }
                if (guess <= GuessesToWin)
                {
                    addingNumbers(RowCoord, ColumnCoord);


                    Console.WriteLine($"Guess number {guess} ");
                }

            }
            if (guess >= GuessesToWin)
            {
                Console.WriteLine($"You missed all the mines. You won!");

            }

        }



    }


}




