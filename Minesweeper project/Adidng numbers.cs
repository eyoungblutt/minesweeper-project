using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_project
{
    internal class Adidng_numbers
    {
        int[,] GridArray = new int[10, 10];
        int Row;
        int Col;

        public void gridNumbers(int row, int col) {

            row = Row;
            col = Col;
        
        }

//        public Adidng_numbers(int row, int col) {
            
//            string hasMine = "Boom!";
//            int mineCount = 0;
           
//            bool isValid(int row, int col)
//            {
//                return (row >= 0) && (col < GridArray.Length) && (col >= 0) && (col < GridArray.Length);
//            }

//            for (int count = 0; count < GridArray.Length; count++) {
                
//                if (MineLocation(row, col) == true)
//                {
//                    return "Boom!"; }

//                else if (isValid(row - 1, col - 1) == true)
//                {
//                    if (hasMine
//                              (row - 1, col - 1) == true)
//                        count++;
//                        }
//                else if (isValid(row - 1, col) == true)
//                {
//                    if (hasMine
//                              (row - 1, col) == true)
//                        count++;
//                            }
//                else if (isValid(row - 1, col + 1) == true)
//                {
//                    if (hasMine
//                              (row - 1, col + 1) == true)
//                        count++;
//                            }
//                else if (isValid(row, col - 1) == true)
//                {
//                    if (hasMine
//                              (row, col - 1) == true)
//                        count++;
//                            }
//                else if (isValid(row, col + 1) == true)
//                {
//                    if (hasMine
//                              (row, col + 1) == true)
//                        count++;
//                            }
//                else if (isValid(row + 1, col - 1) == true)
//                {
//                    if (hasMine
//                              (row + 1, col - 1) == true)
//                        count++;
//                            }
//                else if (isValid(row + 1, col) == true)
//                {
//                    if (hasMine
//                              (row + 1, col) == true)
//                        count++;
//                            }
//                else if (isValid(row + 1, col + 1) == true)
//                {
//                    if (hasMine
//                              (row + 1, col + 1) == true)
//                        count++;
//                            }

//                mineCount += count++;
//}
//            return mineCount;

//        }


    }
}
