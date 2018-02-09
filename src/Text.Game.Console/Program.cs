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
            Welcome();

            bool keepPlaying = true;

            while(keepPlaying) {
            
                string prompt = String.Format("{0}, what is your command?", GameState.Player.Name);
                System.Console.WriteLine(prompt);
                string command = System.Console.ReadLine();

                switch(command.ToLower()){
                    case "quit":
                        keepPlaying = false;
                        break;
                    case "inventory":
                        ShowInventory(GameState.Player.GameObjects);
                        break;
                    default:
                        GameState.Navigate(command);
                        Welcome();
                        break;
                }

                //if(command.ToLower()== "go left" && GameState.CurrentPlace == bedroom) {
                //    GameState.CurrentPlace = kitchen;
               // }
            }

            System.Console.WriteLine("Goodbye!");

            
        }

        private static void Welcome(){

            System.Console.WriteLine(  
                    String.Format("Welcome {0}.  You are in the {1}. {2}",
                    GameState.Player.Name, 
                    GameState.CurrentPlace.Name, 
                    GameState.CurrentPlace.Description ) );
                DescribeGameObjects(GameState.CurrentPlace.GameObjects);

        }

        private static void ShowInventory(List<GameObject> gameObjects) {
            if (GameState.Player.GameObjects.Count == 0) {
                System.Console.WriteLine("You have nothing.");
                return;
            } 
            
            System.Console.Write("You have: ");
            foreach(GameObject o in GameState.Player.GameObjects) {
                System.Console.Write(o.Name + ", ");
                if(o.GameObjects.Count > 0 ){
                    ShowInventory(o.GameObjects);
                }
            }
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
