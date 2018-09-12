﻿using System;
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

        public Sudoku(string initArragement)
        {
            BoardAsText = FormatString(initArragement);            
        }

        public string FormatString (string initArragement)
        {
            char[,] matrix = new char[9, 9];
            string formatedMatrix = "+---------+---------+---------+\n";

            for (int i = 0; i < WidthOfBoard; i++)
            {
                for (int j = 0; j < WidthOfBoard; j++)
                {
                    if (j % 3 == 0)
                    {
                        formatedMatrix += "|";
                    }
                    if (initArragement[j + (i * 9)]=='0')
                    {
                        matrix[i, j] = ' ';
                    } else
                    {
                        matrix[i, j] = initArragement[j + (i * 9)];
                    }                    
                    formatedMatrix += String.Format(" {0} ", matrix[i, j]);
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