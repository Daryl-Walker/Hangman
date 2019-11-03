using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{

    public class Game
    {
        private static string correctWord = "hangman";
        private static char[] correctGuesses;
        private static List<char> incorrectGuesses = new List<char>();
        private static string input;
        private static List<char> guessCount = new List<char>();
        private static Player player;

        public static string CorrectWord { get => correctWord; set => correctWord = value; }
        public static char[] CorrectGuesses { get => correctGuesses; set => correctGuesses = value; }
        public static List<char> IncorrectGuesses { get => incorrectGuesses; set => incorrectGuesses = value; }
        public static string Input { get => input; set => input = value; }
        public static List<char> GuessCount { get => guessCount; set => guessCount = value; }
        public static Player Player { get => player; set => player = value; }

        public static void StartGame()
        {
            CorrectGuesses = new char[Game.CorrectWord.Length];
            for (int i = 0; i < Game.CorrectWord.Length; i++)
            {
                Game.CorrectGuesses[i] = '-';
            }
            Player.AskForUsersName();
        }
        public static void PlayGame()
        {
            do
            {
                Console.Clear();
                DisplayMaskedWord();
                char guessedLetter = AskForLetter();
                CheckLetter(guessedLetter);
                if (!CorrectWord.Contains(guessedLetter))
                {
                    IncorrectGuesses.Add(guessedLetter);
                }
                Console.Clear();

            } while (CorrectWord != new string(CorrectGuesses));
            Console.WriteLine(CorrectWord);
            foreach (char guessedLetter in CorrectGuesses)
            {
                Player.Score += 2;
            }
            EndGame();
        }

        private static void CheckLetter(char guessedLetter)
        {
            for (int i = 0; i < CorrectWord.Length; i++)
            {
                if (guessedLetter == CorrectWord[i])
                {
                    CorrectGuesses[i] = guessedLetter;
                }
            }
        }

        static void DisplayMaskedWord()
        {
            foreach (char item in CorrectGuesses)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static char AskForLetter()
        {
            do
            {
                Console.WriteLine("Enter a Letter:");
                Input = Console.ReadLine();
            } while (Input.Length != 1);

            Player.Guess = Input[0];
            return Player.Guess;
        }

        private static void EndGame()
        {
            Console.WriteLine("Game over...");
            Console.WriteLine($"Thanks for playing {Player.UserName}!");
            Console.WriteLine($"Guess count: {IncorrectGuesses.Count}");
            Console.WriteLine($"Your score: {Player.Score}");
            //PlayAgain();
        }

        //private static void PlayAgain()
        //{
        //    bool Y = true;
        //    string rePlay;
        //    do
        //    {
        //        Console.WriteLine("Play again?  Y/N");
        //        rePlay = Console.ReadLine();
        //        if (Y = rePlay)
        //        {
        //            Console.Clear();
        //            Game.StartGame();
        //        }
        //    } while (rePlay.Length != 1);
        //}
    }
}
