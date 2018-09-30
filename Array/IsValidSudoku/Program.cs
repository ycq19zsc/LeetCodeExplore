using System;
using System.Collections.Generic;
using System.Linq;

namespace IsValidSudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var board = new char[,]{
                {'8','3','.','.','7','.','.','.','.'},
                {'6','.','.','1','9','5','.','.','.'},
                {'.','9','8','.','.','.','.','6','.'},
                {'8','.','.','.','6','.','.','.','3'},
                {'4','.','.','8','.','3','.','.','1'},
                {'7','.','.','.','2','.','.','.','6'},
                {'.','6','.','.','.','.','2','8','.'},
                {'.','.','.','4','1','9','.','.','5'},
                {'.','.','.','.','8','.','.','7','9'}
            };

            var result = IsValidSudoku(board);

        }

        static bool IsValidSudoku(char[,] board)
        {
            //is valid in line or staright
            for (int i = 0; i < 9; i++)
            {
                var dictLine = new Dictionary<int, bool>();
                var dictStaright = new Dictionary<int, bool>();
                for (int j = 0; j < 9; j++)
                {

                    var lineValue = board[i, j];

                    if (lineValue != '.')
                    {
                        if (dictLine.ContainsKey(lineValue))
                        {
                            return false;
                        }
                        else
                        {
                            dictLine[lineValue] = true;
                        }
                    }


                    var starightValue = board[j, i];

                    if (starightValue != '.')
                    {
                        if (dictStaright.ContainsKey(starightValue))
                        {
                            return false;
                        }
                        else
                        {
                            dictStaright[board[j, i]] = true;
                        }
                    }
                }
            }

            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    var dict = new Dictionary<int, bool>();

                    for (int x = i; x < i + 3; x++)
                    {
                        for (int y = j; y < j + 3; y++)
                        {
                            var val = board[x, y];

                            if (val != '.')
                            {

                                if (dict.ContainsKey(val))
                                {
                                    return false;
                                }
                                else
                                {
                                    dict[val] = true;
                                }
                            }
                        }
                    }
                    // System.Console.WriteLine($"{i},{j}");

                }
            }

            return true;
        }

        static bool IsValidSudoku2(char[,] board)
        {
            //is valid in line or staright
            for (int i = 0; i < 9; i++)
            {
                var dictLine = new HashSet<char>();
                var dictStaright = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {

                    var lineValue = board[i, j];

                    if (lineValue != '.')
                    {
                        if (dictLine.Add(lineValue)==false)
                        {
                            return false;
                        }
                    }


                    var starightValue = board[j, i];

                    if (starightValue != '.')
                    {
                        if (dictStaright.Add(starightValue)==false)
                        {
                            return false;
                        }
                    }
                }
            }

            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    var dict = new HashSet<char>();

                    for (int x = i; x < i + 3; x++)
                    {
                        for (int y = j; y < j + 3; y++)
                        {
                            var val = board[x, y];

                            if (val != '.')
                            {

                                if (dict.Add(val)==false)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
