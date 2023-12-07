using System;
using System.Text;

namespace SudokuSolver {
  class Program {
    static void Main(string[] args) {
      int?[,] initialBoard = new int?[,] {
        { null, null, null,    2  , null, null,   null, null,  1   },
        { null, null,  3  ,    8  , null, null,   null,  9  , null },
        {  7  , null,  4  ,   null,  9  ,  5  ,    8  , null, null },

        {  2  ,  8  , null,   null, null, null,   null, null,  5   },
        { null, null, null,   null, null, null,   null, null, null },
        {  6  , null, null,   null, null, null,   null,  7  ,  3   },

        { null, null,  2  ,    7  ,  5  , null,    6  , null,  9   },
        { null,  7  , null,   null, null,  6  ,    4  , null, null },
        {  5  , null, null,   null, null,  9  ,   null, null, null }
      };

      SudokuBoard board = new SudokuBoard(initialBoard);

      bool solved = SudokuSolver.Solve(board);
            if (solved)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0;i< 9;i++) 
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if ((j) % 3 == 0)
                        {
                            if (j % 9 == 0)
                            {
                                sb.Append("\n");
                                if(i % 3 == 0)
                                {
                                    sb.Append('\n');
                                }
                            }
                            else
                            {
                                sb.Append("\t");
                            }

                        }
                        sb.Append(board.board[i,j]);
                        sb.Append(" ");
                    }
                }
                Console.WriteLine(sb);
                Console.Write("\n");
            }
      Console.WriteLine($"{(solved ? "SOLVED" : "UNSOLVABLE")}");
    }
  }
}
