using System;
using Text.Game.Objects;

namespace Text.Game.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What is your name?");
            GameState.Player.Name =  System.Console.ReadLine();


            bool keepPlaying = true;

            while(keepPlaying) {
                System.Console.WriteLine(  String.Format("Welcome {0}.  You are in the {1}",GameState.Player.Name, GameState.CurrentPlace.Name ) );

                string prompt = String.Format("{0}, what is your command?", GameState.Player.Name);
                System.Console.WriteLine(prompt);
                string command = System.Console.ReadLine();
                
                keepPlaying = command.ToLower() != "quit";

                GameState.Navigate(command);

                //if(command.ToLower()== "go left" && GameState.CurrentPlace == bedroom) {
                //    GameState.CurrentPlace = kitchen;
               // }
            }

            System.Console.WriteLine("Goodbye!");

            
        }
    }
}
