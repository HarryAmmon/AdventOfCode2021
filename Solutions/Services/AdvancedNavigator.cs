using Solutions.Models;
using Solutions.Services;

namespace Solutions.Services
{
    public class AdvancedNavigator : INavigator
    {
        public Position ExecuteCommand(string command, Position position)
        {
            string[] parts = command.Split(' ');
            switch (parts[0])
            {
                case "forward":
                    return Forward(int.Parse(parts[1]), position);
                case "down":
                    return Down(int.Parse(parts[1]), position);
                case "up":
                    return Up(int.Parse(parts[1]), position);
                default:
                    return new Position();
            }
        }
        public Position Forward(int units, Position position)
        {
            position.Horizontal += units;
            position.Depth += position.Aim * units;
            return position;
        }
        public Position Down(int units, Position position)
        {
            position.Aim += units;
            return position;
        }


        public Position Up(int units, Position position)
        {
            position.Aim -= units;
            return position;
        }
    }
}