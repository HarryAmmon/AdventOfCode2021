using System;
using System.IO;
using AdventOfCodeCore;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileContent = File.ReadAllLines(@"Inputs/Day3.txt");

            ISolution<int> solutions = new Day3();

            Console.WriteLine(solutions.Part1(fileContent));
            // Console.WriteLine(solutions.Part2(fileContent));
        }
    }
}
