using System;

namespace RotateMatrixImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var matr1 = new int[,]{
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };

            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    Console.Write(matr1[i, j] + " ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            Rotate(matr1);

            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    Console.Write(matr1[i, j] + " ");
                }
                System.Console.WriteLine();
            }

        }

        static void Rotate(int[,] matrix)
        {
            var length = matrix.GetLength(0);
            var maxIndex = length - 1;

            var halfLength = length / 2;

            if (length % 2 == 1)// 奇数个需要额外旋转中线上的四个数
            {
                for (int i = 0; i < halfLength + 1; i++)
                {
                    var x = i;
                    var y = halfLength;

                    var nextX = i;
                    var nextY = halfLength;
                    for (int j = 0; j < 3; j++)
                    {
                        var xyTemp = nextX;
                        nextX = nextY;
                        nextY = maxIndex - xyTemp;

                        var temp = matrix[nextX, nextY];
                        matrix[nextX, nextY] = matrix[x, y];
                        matrix[x, y] = temp;
                    }
                }
            }

            for (int x = 0; x < halfLength; x++)
            {
                for (int y = 0; y < halfLength; y++)
                {
                    var nextX = x;
                    var nextY = y;
                    for (int i = 0; i < 3; i++)
                    {
                        var xyTemp = nextX;
                        nextX = nextY;
                        nextY = maxIndex - xyTemp;

                        var temp = matrix[nextX, nextY];
                        matrix[nextX, nextY] = matrix[x, y];
                        matrix[x, y] = temp;
                    }
                }
            }
        }

    }
}
