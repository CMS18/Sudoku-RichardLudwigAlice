using System;
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
            Sudoku game = new Sudoku("037060000205000800006908000" +
                                "000600024001503600650009000" +
                                "000302700009000402000050360");

            Console.WriteLine(game.BoardAsText);
            game.Solve();
            game.RecursiveSolveStarter();

            if (!game.Solved)
            {
                Console.WriteLine("Jag hittade tyvärr ingen lösning");
            }
        }
    }
}
