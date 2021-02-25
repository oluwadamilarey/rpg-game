namespace rpg_game.Models
{
    public class Character
    {
        public int id{get; set;}
        public string Name{get; set;} = "david";
        public string Hitpoints{get; set;} = 10;
        public int Strength{get; set;} = 20;
        public int Defence{get; set;} = 15;
        public int intelligence{get; set;} = 7;
    }
}