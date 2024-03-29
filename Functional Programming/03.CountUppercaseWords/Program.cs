﻿using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<string, bool> filter = text => Char.IsUpper(text[0]);

            string text = Console.ReadLine();

            string[] words = text.Split();

            words = words.Where(filter).ToArray();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }
    }
}
