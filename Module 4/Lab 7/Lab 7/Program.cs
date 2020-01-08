﻿using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            Console.WriteLine("String is palindrome: " + palindromeCheck(Console.ReadLine()));
        }

        static bool palindromeCheck (string input)
        {
            if (input.Length == 0)
            {
                return true;
            }else if (input[0] != input[input.Length - 1])
            {
                return false;
            }else
            {
                return palindromeCheck(input.TrimStart(input[0]).TrimEnd(input[input.Length - 1]));
            }
        }
    }
}
