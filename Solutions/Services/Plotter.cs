using System;
using System.Collections.Generic;

namespace Solutions.Services
{
    public class Plotter
    {
        public int PlotPoints(List<int[]> points)
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

            var map = CreateBlankMap(largestX, largestY);

            foreach (var coords in points)
            {
                int x1 = coords[0];
                int y1 = coords[1];
                int x2 = coords[2];
                int y2 = coords[3];

                if(x1 == x2)
                {
                    // if the x coords are the same, just loop through the y coords
                    for(int i = y1; i<= y2; i++)
                    {
                        map[x1][i]++;
                    }
                } else if(y1 == y2)
                {
                    for (int i = x1; i <= x2; i++)
                    {
                        map[y1][i]++;
                    }
                }
            }

            int count = 0;
            foreach(var row in map)
            {
                foreach(int item in row)
                {
                    if(item >= 2)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private List<List<int>> CreateBlankMap(int largestX, int largestY)
        {
            var map = new List<List<int>>();

            for (int i = 0; i <= largestY; i++)
            {
                map.Add(new List<int>());
                for (int j = 0; j <= largestX; j++)
                {
                    map[i].Add(0);
                }
            }

            return map;
        }
    }
}