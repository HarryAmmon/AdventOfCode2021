using AdventOfCodeCore;
using Solutions.Models;
using Solutions.Services;

namespace Solutions
{
    public class Day2 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            Position position = new Position();
            INavigator nav = new BasicNavigator();
            foreach (string command in fileContent)
            {
                position = nav.ExecuteCommand(command, position);
            }
            return position.Depth * position.Horizontal;
        }

        public int Part2(string[] fileContent)
        {
            Position position = new Position();
            INavigator nav = new AdvancedNavigator();
            foreach (string command in fileContent)
            {
                position = nav.ExecuteCommand(command, position);
            }
            return position.Depth * position.Horizontal;
        }
    }
}