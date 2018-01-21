using System;
using System.Collections.Generic;
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
                System.Console.WriteLine(  
                    String.Format("Welcome {0}.  You are in the {1}. {2}",
                    GameState.Player.Name, 
                    GameState.CurrentPlace.Name, 
                    GameState.CurrentPlace.Description ) );
                DescribeGameObjects(GameState.CurrentPlace.GameObjects);                

            
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

        private static void DescribeGameObjects(List<GameObject> gameObjects) {
            System.Console.Write("You see: ");
            //+ gameObject.Name 
            //+". Inside the "
           // +gameObject.Name
           // +" you see the following: ");
            foreach(GameObject o in gameObjects) {
                System.Console.Write(o.Name + " ");
                if(o.GameObjects.Count > 0 ){
                    DescribeGameObjects(o.GameObjects);
                }
            }
            System.Console.WriteLine();

        }
    }
}
