using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class Player
    {
        public string userName;
        public static int score;
        public static char guess;

        public Player(string name)
        {
            userName = name;
        }


    }
}
