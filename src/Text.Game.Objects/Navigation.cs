namespace Text.Game.Objects {

    public class Navigation {

        public Navigation( string command, Place fromPlace, Place toPlace) {
            this.Command = command;
            this.FromPlace = fromPlace;
            this.ToPlace = toPlace;
        }

        public string Command {private set; get;}
        public Place FromPlace {private set; get;}
        public Place ToPlace {private set; get;}        
    }

}