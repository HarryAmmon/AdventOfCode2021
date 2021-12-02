using System;
using System.IO;
using AdventOfCodeCore;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileContent = File.ReadAllLines(@"Inputs/Day1.txt");

            ISolution<int> solutions = new Day1();

            Console.WriteLine(solutions.Part1(fileContent));
            Console.WriteLine(solutions.Part2(fileContent));
        }
    }
}
