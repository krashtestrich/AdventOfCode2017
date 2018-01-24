using System;
using AdventOfCode.Logic.Days.Day01;

namespace AdventOfCode.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(@"Welcome to the Advent of Code Console Application!");
            Console.WriteLine(@"Press any key to output solutions for the challenges:");
            Console.ReadLine();

            Console.WriteLine($@"Day01 (part 1): {new Day01Part01(Inputs.Day01).Calculate()}");
            Console.WriteLine($@"Day02 (part 2): {new Day01Part02(Inputs.Day01).Calculate()}");

            Console.ReadLine();
        }
    }
}
