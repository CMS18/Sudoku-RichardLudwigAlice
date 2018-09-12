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

            for (int i = 0; i < WidthOfBoard; i++)
            {
                for (int j = 0; j < WidthOfBoard; j++)
                {
                    if (j % 3 == 0)
                    {
                        formatedMatrix += "|";
                    }
                    if (initialNumbers[j + (i * 9)]=='0')
                    {
                        Matrix[i, j] = ' ';
                    } else
                    {
                        Matrix[i, j] = initialNumbers[j + (i * 9)];
                    }                    
                    formatedMatrix += String.Format(" {0} ", Matrix[i, j]);
                }
                formatedMatrix += "|\n";
                if ((i + 1) % 3 == 0)
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
