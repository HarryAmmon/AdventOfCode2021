using Solutions.Models;

namespace Solutions.Services
{
    public interface INavigator
    {
        Position ExecuteCommand(string command, Position position);
        Position Forward(int units, Position position);
        Position Up(int units, Position position);
        Position Down(int units, Position position);
    }
}