using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class Player
    {
        public static string userName;
        public static int score;
        public static char guess;

        public Player(string name)
        {
            userName = name;
        }
        public static string AskForUsersName()
        {
            Player player = new Player(string.Empty);
            do
            {
                Console.WriteLine("What is your name? (must be at least 2 characters)");
                Player.userName = Console.ReadLine();
            } while (Player.userName.Length < 2);

            return Player.userName;
        }

    }
}
