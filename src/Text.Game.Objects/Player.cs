using System.Collections.Generic;

namespace Text.Game.Objects
{
    public class Player
    {

        public Player() {
            this.GameObjects = new List<GameObject>();
        }
        public string Name {get;set;}

        public  List<GameObject> GameObjects { set; get;}
    }
}
