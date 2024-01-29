

using MathGame.Models;

namespace MathGame;

static class History
{
    public static List<Game> games = new List<Game>();

    public static void Display()
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        foreach(var game in games)
            Console.WriteLine(game);
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public static void Add(Game game)
    {
        games.Add(game);
    }
}
