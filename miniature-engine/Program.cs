﻿using System;

namespace miniature_engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringCalculator stringCalculator = new StringCalculator();

            Console.WriteLine(stringCalculator.Add("//;\n1;2;3;-4;5;-6;7;-8;9;10"));
        }
    }
}
