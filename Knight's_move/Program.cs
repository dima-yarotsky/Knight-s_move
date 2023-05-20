using Knight_s_move;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class KnightPaths
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Input(out var m, out var n);
            var calc = new KnightPathsCalculator(m, n);
            var result = calc.GetPaths();
            Console.WriteLine(result);
        }

        private static void Input(out int m, out int n)
        {
            Console.WriteLine("Введите число M:");
            while (!int.TryParse(Console.ReadLine(), out m) ||  m is > 15 or < 1)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число M от 1 до 15:");
            }

            Console.WriteLine("Введите число N:");
            while (!int.TryParse(Console.ReadLine(), out n) || n is > 15 or < 1)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число N от 1 до 15:");
            }
        }
    }
}