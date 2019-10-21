using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
       
        public Game game;
        public Player player;

        static void Main(string[] args)
        {
            Game.StartGame();
            Game.PlayGame();
        }
        
        
    }
}
