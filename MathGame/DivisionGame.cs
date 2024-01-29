using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.Models;

namespace MathGame
{
    public class DivisionGame : IGame
    {
        private int _score;
        public void play()
        {
            Console.WriteLine("==============Division Game==============");
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(1, 99);
                int secondNumber = random.Next(1, 99);

                // validate numbers
                while(firstNumber % secondNumber != 0)
                {
                     firstNumber = random.Next(1, 99);
                     secondNumber = random.Next(1, 99);
                }
                Console.Write($"{firstNumber} / {secondNumber} = ");
                string input = Console.ReadLine();
                int res;

                if (!int.TryParse(input, out res))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Enter Valid Integer");
                    Console.BackgroundColor = ConsoleColor.Black;
                    continue;
                }

                if (res == firstNumber / secondNumber)
                {
                    this._score++;
                }
            }

            History.Add(new Game() { Date = DateTime.Now, Score = this._score, Type = Enum.GameType.DIVISION });

        }
    }
}
