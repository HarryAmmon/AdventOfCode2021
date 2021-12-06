using System;
using Solutions.Models;

namespace Solutions.Services
{
    public class BinaryDiagnosticMachine
    {
        public int CalculatePowerConsumption(string[] report)
        {
            int gammaRate = CalculateGammaRate(report);
            int epsilonRate = CalculateEpsilonRate(report);
            return gammaRate * epsilonRate;
        }
        public int CalculateLifeSupportRating(string[] report)
        {
            int o2Rating = CalculateO2Rating(report);
            int co2ScrubbingRating = CalculateCO2ScrubbingRating(report);
            return o2Rating * co2ScrubbingRating;
        }

        private int CalculateCO2ScrubbingRating(string[] report)
        {
            throw new NotImplementedException();
        }

        private int CalculateO2Rating(string[] report)
        {
            throw new NotImplementedException();
        }

        private int CalculateGammaRate(string[] report)
        {
            string binaryNumber = "";
            for (int i = 0; i < report[0].Length; i++)
            {
                binaryNumber += FindMostCommonBit(report, i);
            }
            return Convert.ToInt32(binaryNumber, 2);
        }
        private int CalculateEpsilonRate(string[] report)
        {
            string binaryNumber = "";
            for (int i = 0; i < report[0].Length; i++)
            {
                binaryNumber += FindLeastCommonBit(report, i);
            }
            return Convert.ToInt32(binaryNumber, 2);
        }

        private char FindMostCommonBit(string[] report, int position)
        {
            var bits = CountBits(report, position);
            if (bits.Zeros > bits.Ones)
            {
                return '0';
            }
            else return '1';
        }

        private char FindLeastCommonBit(string[] report, int position)
        {
            var bits = CountBits(report, position);
            if (bits.Zeros < bits.Ones)
            {
                return '0';
            }
            else return '1';
        }
        private Bits CountBits(string[] report, int position)
        {
            var bits = new Bits();
            foreach (var line in report)
            {
                if (line[position] == '1')
                {
                    bits.Ones++;
                }
                else if (line[position] == '0')
                {
                    bits.Zeros++;
                }
            }
            return bits;
        }
    }
}