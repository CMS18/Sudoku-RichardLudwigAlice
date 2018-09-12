using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Sudoku
    {
        const int WidthOfBoard = 9;
       
        public string BoardAsText { get; set; }
        public char[,] Matrix { get; set; }

        public Sudoku(string initialNumbers)
        {
            Matrix = new char[WidthOfBoard, WidthOfBoard];
            BoardAsText = StringToSudokuBoard(initialNumbers);            
        }

        public string StringToSudokuBoard (string initialNumbers)
        {
            string formatedMatrix = "+---------+---------+---------+\n";

            for (int row = 0; row < WidthOfBoard; row++)
            {
                for (int col = 0; col < WidthOfBoard; col++)
                {
                    if (col % 3 == 0)
                    {
                        formatedMatrix += "|";
                    }
                    if (initialNumbers[col + (row * 9)]=='0')
                    {
                        Matrix[row, col] = ' ';
                    } else
                    {
                        Matrix[row, col] = initialNumbers[col + (row * 9)];
                    }                    
                    formatedMatrix += String.Format(" {0} ", Matrix[row, col]);
                }
                formatedMatrix += "|\n";
                if ((row + 1) % 3 == 0)
                {
                    formatedMatrix += "+---------+---------+---------+\n";
                }
            }            
            return formatedMatrix;
        }
               
        public void Solve()
        {

        }


    }
}
