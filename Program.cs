using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {

        // public Game Game;
        //  public Player player;

        static void Main(string[] args)
        {
            Game.StartGame();
            try
            {
            Game.PlayGame();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong...");
                Console.ReadLine();
            }
        }
        
        
    }
}
