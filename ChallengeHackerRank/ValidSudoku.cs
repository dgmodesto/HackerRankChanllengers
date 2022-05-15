using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class ValidSudoku
    {
        /*
         https://leetcode.com/explore/learn/card/hash-table/185/hash_table_design_the_key/1126/
         
         */


        public static bool IsValidSudoku(char[][] board)
        {
            var mtx = new Dictionary<int, List<char>>();
            var col = new Dictionary<int, List<char>>();
            var row = new Dictionary<int, List<char>>();

            for (int i = 0; i < 10; i++)
            {
                mtx.Add(i + 1, new List<char>());
                col.Add(i + 1, new List<char>());
                row.Add(i + 1, new List<char>());
            }
            var result = true;
            for (int i = 0; i < board.Length; i++)
            {

                for (int j = 0; j < board[i].Length; j++)
                {


                    if (board[i][j] == '.') continue;

                    if (col[j+1].Contains(board[i][j]) ||
                        row[i+1].Contains(board[i][j]))
                        result = false;
                    else
                    {
                        col[j+1].Add(board[i][j]);
                        row[i+1].Add(board[i][j]);
                    }


                    if (i <= 2 && j <= 2)
                    {
                        if (mtx[1].Contains(board[i][j]) )
                            result = false;

                        mtx[1].Add(board[i][j]);
                        continue;
                    }
                    else if (i <= 2 && j > 2 && j <= 5)
                    {
                        if (mtx[2].Contains(board[i][j]))
                            result = false;

                        mtx[2].Add(board[i][j]);
                        continue;
                    }
                    else if (i <= 2 && j > 5 && j <= 8)
                    {
                        if (mtx[3].Contains(board[i][j]))
                            result = false;

                        mtx[3].Add(board[i][j]);
                        continue;
                    }

                    /*--------------------------------*/
                    if (i > 2 && i <= 5 && j <= 2)
                    {
                        if (mtx[4].Contains(board[i][j]))
                            result = false;

                        mtx[4].Add(board[i][j]);
                        continue;
                    }
                    else if (i > 2 && i <= 5 && j > 2 && j <= 5)
                    {
                        if (mtx[5].Contains(board[i][j]))
                            result = false;

                        mtx[5].Add(board[i][j]);
                        continue;
                    }
                    else if (i > 2 && i <= 5 && j > 5 && j <= 8)
                    {
                        if (mtx[6].Contains(board[i][j]))
                            result = false;

                        mtx[6].Add(board[i][j]);
                        continue;
                    }



                    /*--------------------------------*/
                    if (i > 5 && i <= 8 && j <= 2)
                    {
                        if (mtx[7].Contains(board[i][j]))
                            result = false;

                        mtx[7].Add(board[i][j]);
                        continue;
                    }
                    else if (i > 5 && i <= 8 && j > 2 && j <= 5)
                    {
                        if (mtx[8].Contains(board[i][j]))
                            result = false;

                        mtx[8].Add(board[i][j]);
                        continue;
                    }
                    else if (i > 5 && i <= 8 && j > 5 && j <= 8)
                    {
                        if (mtx[9].Contains(board[i][j]))
                            result = false;

                        mtx[9].Add(board[i][j]);
                        continue;
                    }
                }
            }
            return result;
        }


        public static void Initial(string [] args)
        {
            //char[] r1 = { '8', '3', '.', '.', '7', '.', '.', '.', '.' };
            //char[] r2 = { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            //char[] r3 = { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            //char[] r4 = { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            //char[] r5 = { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            //char[] r6 = { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            //char[] r7 = { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            //char[] r8 = { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            //char[] r9 = { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

            //char[] r1 = { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            //char[] r2 = { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            //char[] r3 = { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            //char[] r4 = { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            //char[] r5 = { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            //char[] r6 = { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            //char[] r7 = { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            //char[] r8 = { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            //char[] r9 = { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

            //char[] r1 = { '.', '.', '4', '.', '.', '.', '6', '3', '.' };
            //char[] r2 = { '.', '.', '.', '.', '.', '.', '.', '.', '.' };
            //char[] r3 = { '5', '.', '.', '.', '.', '.', '.', '9', '.' };
            //char[] r4 = { '.', '.', '.', '5', '6', '.', '.', '.', '.' };
            //char[] r5 = { '4', '.', '3', '.', '.', '.', '.', '.', '1' };
            //char[] r6 = { '.', '.', '.', '7', '.', '.', '.', '.', '.' };
            //char[] r7 = { '.', '.', '.', '5', '.', '.', '.', '.', '.' };
            //char[] r8 = { '.', '.', '.', '.', '.', '.', '.', '.', '.' };
            //char[] r9 = { '.', '.', '.', '.', '.', '.', '.', '.', '.' };

            char[] r1 = { '.', '8', '7', '6', '5', '4', '3', '2', '1' };
            char[] r2 = { '2', '.', '.', '.', '.', '.', '.', '.', '.' };
            char[] r3 = { '3', '.', '.', '.', '.', '.', '.', '.', '.' };
            char[] r4 = { '4', '.', '.', '.', '.', '.', '.', '.', '.' };
            char[] r5 = { '5', '.', '.', '.', '.', '.', '.', '.', '.' };
            char[] r6 = { '6', '.', '.', '.', '.', '.', '.', '.', '.' };
            char[] r7 = { '7', '.', '.', '.', '.', '.', '.', '.', '.' };
            char[] r8 = { '8', '.', '.', '.', '.', '.', '.', '.', '.' };
            char[] r9 = { '9', '.', '.', '.', '.', '.', '.', '.', '.' };

            char[][] board = new char[][]
            {
                 r1
                ,r2
                ,r3
                ,r4
                ,r5
                ,r6
                ,r7
                ,r8
                ,r9
            };


            Console.WriteLine(IsValidSudoku(board));
        }
    }
}
