using System;

namespace Minesweeper_project // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coordinate1;
            int coordinate2;    


            int[,] GridArray = new int[9, 9]; //creating an multidimensional array
            Console.WriteLine("Pick your Coordinates"); //first coordinate is entered
            coordinate1 = Convert.ToInt32(Console.ReadLine());

            
             coordinate2 = Convert.ToInt32(Console.ReadLine()); //second coordinate is entered and returns below value that has been assigned to the grid array coordinate.
            GridArray[coordinate1, coordinate2] = 4; //assigning value to a specific part of the array
            GridArray [5, 3] = 5;

            // have people readline and enter two coordinates which are fed into the below?


            Console.WriteLine(GridArray[coordinate1, coordinate2]); //returning the value at this apr tof the array 
            Console.WriteLine(GridArray [5, 3]);
            //Console.WriteLine(GridArray[9, 9]); showa up as outside the bounds of the array?


            //foreach (var i in GridArray)
            ////{
            ////    Console.WriteLine(i); //displays a row of zeros
            //}
           

            // Console.WriteLine("Welcome to Minesweeper");
            //Console.WriteLine("What is your name?");
            // name = Console.ReadLine();
            //Console.WriteLine($"Welcome {name}, lets play!");



        }


        //MultiDimensional Array 
        //coordinates would be rrow/column
        //row horizozntal starts at 0 - 9
        //clumn - vertical goes from 0 - 9
        // player would enter coordinated 4, 8 and the square at row 4 column 8 would then say either number or mine.


    }
}