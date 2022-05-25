using System;

namespace Minesweeper_project // Note: actual namespace depends on the project name.
{
    internal class Program // CREATES GRID AND USER INPUT
    {
        static void Main(string[] args)
        {

            int[,] grid = Mines.plantBombs(); 

           
                int[,] userGrid = new int[10, 10];
                
                for (int i = 0; i < 10; i++) // planting bombs in the new grid array
                {
                    for (int j = 0; j < 10; j++)
                    {


                        int col = i ;
                        int row = j ;
                        userGrid[row, col] = grid[i,j]; //original tutorial had a .mine added on for it??
                      // Console.WriteLine(userGrid[row, col]); // how has 10 x mines = 0
                    }

                }

            bool isValid(int row, int col)
            {
                return (row >= 0) && (col <= 9) && (col >= 0) && (row <= 9);

            }


            void addingNumbers(int row, int col)
                {

                    int minesNearBy;
                   
                            for (int count = 0; count < 90; count++)
                            {


                                if (isValid(row - 1, col - 1) == true && userGrid[row - 1, col - 1] == 0)
                                {

                                    count++;

                                }


                                if (isValid(row - 1, col) == true && userGrid[row - 1, col] == 0)
                                {
                                    count++;
                                }


                                if (isValid(row - 1, col + 1) == true && userGrid[row - 1, col + 1] == 0)
                                {

                                    count++;

                                }

                                if (isValid(row, col - 1) == true && userGrid[row, col - 1] == 0)
                                {

                                    count++;

                                }

                                if (isValid(row, col + 1) == true && userGrid[row, col + 1] == 0)
                                {

                                    count++;

                                }

                                if (isValid(row + 1, col - 1) == true && userGrid[row + 1, col - 1] == 0)
                                {

                                    count++;
                                }

                                if (isValid(row + 1, col) == true)
                                {
                                    if (userGrid[row + 1, col] == 0)
                                    {

                                        count++;

                                    }

                                    if (isValid(row + 1, col + 1) == true && userGrid[row + 1, col + 1] == 0)
                                    {

                                        count++;
                                    }
                                }
                                //else if (userGrid[row, col] == 0)
                                //{
                                //    Console.WriteLine("Boom!");
                                //    break;
                                //}
                                minesNearBy = count;

                                Console.WriteLine("Be careful! There are " + minesNearBy + " bombs near you");
                                break;

                            }
                            Console.WriteLine();
                           

                  
                }
               

                int RowCoord;
                int ColumnCoord;



                Console.WriteLine("Welcome to MineSweeper!");
                    Console.WriteLine("To play, enter two coordinates e.g 5 then 8 to sweep for mines");

                int GuessesToWin = 90;
                int guess;
                for ( guess = 0; guess < GuessesToWin; guess++)
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


    

