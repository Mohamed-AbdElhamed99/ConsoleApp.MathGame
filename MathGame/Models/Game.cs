using MathGame.Enum;

namespace MathGame.Models;

internal class Game
{
    public int Score { get; set; }
    public DateTime Date { get; set; }
    public GameType Type { get; set; }

    public override string ToString()
    {
        return $"[{Date}] - {Type} : {Score} pts";
    }
}


