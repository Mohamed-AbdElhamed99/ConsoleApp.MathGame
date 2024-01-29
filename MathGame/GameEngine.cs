using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.Models;

namespace MathGame
{
    public class GameEngine
    {
        private static bool inGame = true;


       /**
        * Here where game starts
        */
        public static void StartGame()
        {
            Console.WriteLine("==============Math Game==============");
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome {name} To Math Game [{DateTime.Now.Date}]");



            while(inGame)
            {
                Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ── ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                Console.WriteLine("What game you would like to play today? please choose from list below");
                Console.WriteLine($@"
        A - Addition
        S - Subtraction
        M - Multiblication
        D - Division
        H - History
        Q - Quit");

                Console.WriteLine("─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ── ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─");
                Console.Write("Enter your choice : ");
                string gameChoice = Console.ReadLine();
                Console.Clear();
                BranchGame(gameChoice);
            }
            
        }

   

        public static void BranchGame(string input)
        {
            Play play ;

            switch (input.ToLower().Trim())
            {
                case "a":
                    AdditionGame additionGame = new AdditionGame();
                    play = new Play(additionGame);
                    play.StartGame();
                    break;
                case "s":
                    SubtractionGame dubtractionGame = new SubtractionGame();
                    play = new Play(dubtractionGame);
                    play.StartGame();
                    break;
                case "m":
                    MultiplicationGame multiplicationGame = new MultiplicationGame();
                    play = new Play(multiplicationGame);
                    play.StartGame();
                    break;
                case "d":
                    DivisionGame divisionGame = new DivisionGame();
                    play = new Play(divisionGame);
                    play.StartGame();
                    break;
                case "q":
                    inGame = false;
                    Console.WriteLine("Good Bye");
                    break;
                case "h":
                    History.Display();
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Enter Valid Choice");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;

            }
        }
    }
}
