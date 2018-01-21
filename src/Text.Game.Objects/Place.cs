using System.Collections.Generic;

namespace Text.Game.Objects{
    public class Place {

        public Place() {
            this.GameObjects = new List<GameObject>();
        }

        public string Name {get;set;}
        public string Description {get;set;}
        public  List<GameObject> GameObjects { set; get;}

    } 

}