﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split();


                for (int j = 0; j < input.Length; j++)
                {

                    elements.Add(input[j]);

                }

            }

            Console.WriteLine(String.Join(" ", elements));

        }
    }
}
