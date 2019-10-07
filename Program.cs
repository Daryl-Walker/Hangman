using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static string userName;
        private static List<char> guessCount = new List<char>();
        static string correctWord = "hangman";
        private static char guess;
        static char[] correctGuesses;
        static List<char> incorrectGuesses = new List<char>();
        private static char wrongGuess;
        private static string input;

        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }
        private static void StartGame()
        {
            correctGuesses = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
            {
                correctGuesses[i] = '-';
            }
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            Console.WriteLine("What is your name? (must be at least 2 characters)");
            userName = Console.ReadLine();

            if (userName.Length < 2)
            {
                AskForUsersName();
            }
        }

        private static void PlayGame()
        {
            do
            {
                Console.Clear();
                DisplayMaskedWord();
                char guessedLetter = AskForLetter();
                CheckLetter(guessedLetter);
                if (!correctWord.Contains(guessedLetter))
                {
                    incorrectGuesses.Add(guessedLetter);
                }
                Console.Clear();

            } while (correctWord != new string(correctGuesses));
            Console.WriteLine(correctWord);
        }

        private static void CheckLetter(char guessedLetter)
        {
            for (int i = 0; i < correctWord.Length; i++)
            {
                if (guessedLetter == correctWord[i])
                {
                    correctGuesses[i] = guessedLetter;
                }
            }
        }

        static void DisplayMaskedWord()
        {
            foreach (char item in correctGuesses)
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
                input = Console.ReadLine();
            } while (input.Length != 1);

            guess = input[0];
            return guess;
        }

        private static void EndGame()
        {
            Console.WriteLine("Game over...");
            Console.WriteLine($"Thanks for playing {userName}!");
            Console.WriteLine($"Guess count: {incorrectGuesses.Count}");
        }
    }
}
