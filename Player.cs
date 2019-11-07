using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class Player
    {
        //private string userName;
        // private int score;

        //   public static int Score { get => Score; set => Score = 0; }
        public static int Score { get ; set ; }

        //public string UserName { get => userName; set => userName = value; }
        public static string UserName { get ; set ; }
        public static char Guess { get; set; }

        public static string AskForUsersName()
        {
           // Player player = new Player();
            do
            {
                Console.WriteLine("What is your name? (must be at least 2 characters)");
                Player.UserName = Console.ReadLine();
            } while (Player.UserName.Length < 2);

            return Player.UserName;
        }

    }
}
