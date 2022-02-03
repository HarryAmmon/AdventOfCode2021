using System;
using System.Collections.Generic;

namespace Solutions.Services
{
    public class Plotter
    {
        public List<List<int>> PlotPoints(List<int[]> points)
        {
            // List<int[]> points = new List<int[]>()
            // {
            //     new int[]{1,1, 1, 5},
            //     new int[]{1,1,5,1}
            // };

            // expected result
            // 0 0 0 0 0 0
            // 0 2 1 1 1 1
            // 0 1 0 0 0 0
            // 0 1 0 0 0 0
            // 0 1 0 0 0 0

            List<List<int>> map = new List<List<int>>();

            // Find the largest x value, add that number of 0 to array
            // Find the largest y value, add that number of List<int> with largest x value of zeros change

            int largestX = 0;
            int largestY = 0;
            foreach (var coords in points)
            {
                if (coords[0] > largestX)
                {
                    largestX = coords[0];
                }
                if (coords[2] > largestX)
                {
                    largestX = coords[2];
                }
                if (coords[1] > largestY)
                {
                    largestY = coords[1];
                }
                if (coords[3] > largestY)
                {
                    largestY = coords[3];
                }
            }
            for (int i = 0; i < largestY; i++)
            {
                map.Add(new List<int>());
                for (int j = 0; j < largestX; j++)
                {
                    map[i].Add(0);
                }
            }

            Console.WriteLine(map.Count);
            Console.WriteLine(map[500].Count);

            foreach (var coords in points)
            {
                int x1 = coords[0];
                int y1 = coords[1];
                int x2 = coords[2];
                int y2 = coords[3];

                // 
            }

            return map;
        }
    }
}