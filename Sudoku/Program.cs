﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Sudoku game = new Sudoku("037060000205000800006908000" +
                                "000600024001503600650009000" +
                                "000302700009000402000050360");
            */
            string easy1 = "003020600900305001001806400008102900700000008006708200002609500800203009005010300";
            string easy2 = "619030040270061008000047621486302079000014580031009060005720806320106057160400030";
            string medium1 = "037060000205000800006908000000600024001503600650009000000302700009000402000050360";
            string diabolic1 = "000000000000003085001020000000507000004000100090000000500000073002010000000040009";
            string diabolic2 = "900040000000010200370000005000000090001000400000705000000020100580300000000000000";
            string unsolvable1 = "009028700806004005003000004600000000020713450000000002300000500900400807001250300";
            string unsolvable2 = "090300001000080046000000800405060030003275600060010904001000000580020000200007060";
            string unsolvable3 = "000041000060000020002000000320600000000050041700000002000000230048000000501002000";
            string unsolvable4 = "900100004014030800003000090000708001800003000000000030021000070009040500500016003";
            string unsolvable5 = "040100350000000000000205000000408900260000012050300007004000160600007000010080020";
            string testBoard = "305420810487901506029056374850793041613208957074065280241309065508670192096512408";

            Sudoku game = new Sudoku(testBoard);
                        
            Console.WriteLine(game.BoardAsText);
            game.Solve();
            if (game.Solved)
            {
                Console.WriteLine(game.BoardAsText);
            }
            else
            {
            game.RecursiveSolveStarter();
            }

            if (!game.Solved)
            {
                Console.WriteLine("Jag hittade tyvärr ingen lösning");
            }
        }
    }
}
