using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
       
        public Game game;
        static Player player;

        static void Main(string[] args)
        {
            StartGame();
            Game.PlayGame();
        }
        private static void StartGame()
        {
            Game.correctGuesses = new char[Game.correctWord.Length];
            for (int i = 0; i < Game.correctWord.Length; i++)
            {
                Game.correctGuesses[i] = '-';
            }
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            do
            {

                Console.WriteLine("What is your name? (must be at least 2 characters)");
                player.userName = Console.ReadLine();

            } while (player.userName.Length < 2);
        }
    }
}
