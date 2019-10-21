﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{

    public class Game
    {
        public static string correctWord = "hangman";
        public static char[] correctGuesses;
        public static List<char> incorrectGuesses = new List<char>();
        public static string input;
        public static List<char> guessCount = new List<char>();
        static Player player;
        public static void PlayGame()
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
                    Player.score++;
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

            Player.guess = input[0];
            return Player.guess;
        }

        private static void EndGame()
        {
            Console.WriteLine("Game over...");
            Console.WriteLine($"Thanks for playing {player.userName}!");
            Console.WriteLine($"Guess count: {incorrectGuesses.Count}");
            Console.WriteLine($"Your score: {Player.score}");
            PlayAgain();
        }

        private static void PlayAgain()
        {
            bool Y = true;
            string rePlay;
            Console.Clear();
            do
            {
                Console.WriteLine("Play again?  Y/N");
                rePlay = Console.ReadLine();
                if (Y)
                {
                    Console.Clear();
                    PlayGame();
                }
            } while (rePlay.Length != 1);
        }
    }
}