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
            GameState.Places.Add(bedroom);

            Place kitchen = new Place();
            kitchen.Name = "Kitchen";
            GameState.Places.Add(kitchen);

            Place livingRoom = new Place();
            livingRoom.Name = "Living Room";
            GameState.Places.Add(livingRoom);

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