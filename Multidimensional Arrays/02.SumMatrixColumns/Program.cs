﻿using System;
using System.Linq;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];


            for (int row = 0; row < rows; row++)
            {

                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }


            for (int col = 0; col < cols; col++)
            {


                int sumOfCols = 0;

                for (int row = 0; row < rows; row++)
                {
                    sumOfCols += matrix[row, col];
                }

                Console.WriteLine(sumOfCols);
                sumOfCols = 0;

            }


        }
    }
}
