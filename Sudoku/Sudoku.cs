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
            for (int row = 0; row < WidthOfBoard; row++)
            {
                for (int col = 0; col < WidthOfBoard; col++)
                {
                    if (CellIsEmpty(row, col) == true)
                    {
                        for (int number = 1; number <= 9; number++)
                        {
                            if (IsExclusiveInRow(number, row))
                            {
                                if (IsExclusiveInColumn(number, col))
                                {
                                    if (IsExclusiveInUnit(number, row, col))
                                    {
                                        FillBoard(number, row, col);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool CellIsEmpty(int row, int col)
        {
            if (Matrix[row, col] == ' ')
                return true;
            else
                return false;
        }

        public bool IsExclusiveInRow(int number, int row)
        {
            for (int i = 0; i < WidthOfBoard; i++)
            {
                if (Matrix[row, i] == number)
                    return false;
            }
            return true;
        }

        public bool IsExclusiveInColumn(int number, int col)
        {
            for (int i = 0; i < WidthOfBoard; i++)
            {
                if (Matrix[i, col] == number)
                    return false;
            }
            return true;
        }

        public bool IsExclusiveInUnit(int number, int row, int col)
        {
            CheckUnitStart(row, col, out int firstRowPositionInUnit, out int firstColumnPositionInUnit);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                }
            }
        }

        public void CheckUnitStart(int row, int col, out int firstRowPositionInUnit, out int firstColumnPositionInUnit)
        {
            if (row < 3 && col < 3)
            {
                firstColumnPositionInUnit = 0;
                firstRowPositionInUnit = 0;
            }
            else if ((row < 3) && (col > 2 && col < 6))
            {
                firstColumnPositionInUnit = 3;
                firstRowPositionInUnit = 0;
            }
            else if ((row < 3) && (col > 5))
            {
                firstColumnPositionInUnit = 6;
                firstRowPositionInUnit = 0;
            }
            else if ((row > 3 && row < 6) && (col < 3))
            {
                firstColumnPositionInUnit = 0;
                firstRowPositionInUnit = 3;
            }
            else if ((row > 5) && (col < 3))
            {
                firstColumnPositionInUnit = 0;
                firstRowPositionInUnit = 6;
            }
            else if ((row > 3 && row < 6) && (col > 2 && col < 6))
            {
                firstColumnPositionInUnit = 3;
                firstRowPositionInUnit = 3;
            }
            else if ((row > 5) && (col > 2 && col < 6))
            {
                firstColumnPositionInUnit = 3;
                firstRowPositionInUnit = 6;
            }
            else if ((row > 2 && row < 6) && (col > 5))
            {
                firstColumnPositionInUnit = 6;
                firstRowPositionInUnit = 3;
            }
            else 
            {
                firstColumnPositionInUnit = 6;
                firstRowPositionInUnit = 6;
            }

        }
    }
}
