using System.Collections.Generic;

namespace Text.Game.Objects {

    public class GameObject {

        public GameObject() {
            this.GameObjects = new List<GameObject>();

        }

        public string Name { set; get;}

        public  List<GameObject> GameObjects { set; get;}

        private  void init(){
            

        }
    }

}