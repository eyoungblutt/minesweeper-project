using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_project
{
    internal class CheckCoordinateValidity
    {
        public static bool isValid(int row, int col)
        {
            return (row >= 0) && (col <= 9) && (col >= 0) && (row <= 9);

        }
    }
}
