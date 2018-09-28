using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sudoku.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string testBoard = "305420810487901506029056374850793041613208957074065280241309065508670192096512408";
            string expected = "365427819487931526129856374852793641613248957974165283241389765538674192796512438";
            // Act
            Sudoku game = new Sudoku(testBoard);

            // Assert

        }
    }
}
