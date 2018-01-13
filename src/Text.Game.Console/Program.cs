using System;
using Text.Game.Objects;

namespace Text.Game.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player();

            // setup places
            Place currentPlace = new Place();
            currentPlace.Name = "Bedroom";
            // end setup places

            System.Console.WriteLine("What is you name?");
            playerOne.Name =  System.Console.ReadLine();

            System.Console.WriteLine(  String.Format("Welcome {0}.  You are in the {1}", playerOne.Name, currentPlace.Name ) );
        }
    }
}
