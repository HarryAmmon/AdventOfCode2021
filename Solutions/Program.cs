using System;
using System.IO;
using AdventOfCodeCore;

namespace Solutions
{
    class Program
    {
        static void Main()
        {
            string[] fileContent = File.ReadAllLines(@"Inputs/Day5.txt");

            ISolution<int> solutions = new Day5();

            Console.WriteLine(solutions.Part1(fileContent));
            Console.WriteLine(solutions.Part2(fileContent));
        }
    }
}
