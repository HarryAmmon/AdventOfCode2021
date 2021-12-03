using System;
using AdventOfCodeCore;
using Solutions.Services;

namespace Solutions
{
    public class Day3 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            var machine = new BinaryDiagnosticMachine();
            return machine.CalculatePowerConsumption(fileContent);
        }

        public int Part2(string[] fileContent)
        {
            throw new System.NotImplementedException();
        }
    }
}