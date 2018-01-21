using System.Collections.Generic;


namespace Text.Game.Objects
{
    public class GameState {
        
        private GameState() {}
        
        static GameState() {
            GameState.GameInstance = new GameState();
            GameState.Init();
        }

        private static void Init(){

            GameState.Player = new Player();

            GameState.Places = new List<Place>();

            Place bedroom = new Place();
            bedroom.Name = "Bedroom";
            bedroom.Description = "The walls are painted blue. There is a bed in front of you and a door on the right and left.";
            GameState.Places.Add(bedroom);

            Place kitchen = new Place();
            kitchen.Name = "Kitchen";
            kitchen.Description = "The walls are yellow with splats of red. There's a knife on the table and a door on the right.";
            GameState.Places.Add(kitchen);

            Place livingRoom = new Place();
            livingRoom.Name = "Living Room";
            livingRoom.Description = "the walls are green.  There is a door on the left. There's a table with a bag on it.";
            GameState.Places.Add(livingRoom);

            GameObject knife = new GameObject();
            knife.Name = "Knife";

            GameObject lamp = new GameObject();
            lamp.Name = "Lamp";

            GameObject bag = new GameObject();
            bag.Name = "Bag";
            bag.GameObjects.Add(knife);
            bag.GameObjects.Add(lamp);

            livingRoom.GameObjects.Add(bag);

            GameState.Navigations.Add ( new Navigation("go left", bedroom, kitchen));

            GameState.Navigations.Add ( new Navigation("go right", bedroom, livingRoom));

            GameState.Navigations.Add ( new Navigation("go right", kitchen, bedroom));

            GameState.Navigations.Add ( new Navigation("go left", livingRoom, bedroom));

            GameState.CurrentPlace = bedroom;

        }


        public static void Navigate(string command) {
            foreach(Navigation n in GameState.Navigations){
                if( command == n.Command && GameState.CurrentPlace == n.FromPlace) {
                    GameState.CurrentPlace = n.ToPlace;
                    break;
                }
            }
        }

        private static List<Navigation> Navigations = new List<Navigation>();

        public static List<Place> Places {private set; get;}

        public static Place CurrentPlace {private set; get;}

        public static Player Player {private set; get;}

        public static GameState GameInstance {private set; get;}

    }
}