using System;
using System.IO;
using AdventOfCodeCore;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileContent = File.ReadAllLines(@"Inputs/Day2.txt");

            ISolution<int> solutions = new Day2();

            Console.WriteLine(solutions.Part1(fileContent));
            Console.WriteLine(solutions.Part2(fileContent));
        }
    }
}
