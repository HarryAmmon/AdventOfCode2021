using System;
using System.Collections.Generic;
using AdventOfCodeCore;
using Solutions.Services;

namespace Solutions
{
    public class Day5 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            List<int[]> coords = new List<int[]>();
            foreach (string line in fileContent)
            {
                var result = line.Split(" -> ", 2);
                string[] coords1 = result[0].Split(',');
                string[] coords2 = result[1].Split(',');
                int[] points = { int.Parse(coords1[0]), int.Parse(coords1[1]), int.Parse(coords2[0]), int.Parse(coords2[1]) };
                if (points[0] == points[2] || points[1] == points[3])
                {
                    coords.Add(points);
                }
            }
            var plotter = new Plotter();
            plotter.PlotPoints(coords);


            throw new System.NotImplementedException();
        }

        public int Part2(string[] fileContent)
        {
            throw new System.NotImplementedException();
        }
    }
}