using rpg_game.Models;

namespace rpg_game.Dtos.Character
{
    public class AddCharacterDto
    {
        public int id{get; set;}
        public string Name{get; set;} = "David";
        public int Hitpoints{get; set;} = 10;
        public int Strength{get; set;} = 20;
        public int Defence{get; set;} = 15;
        public int intelligence{get; set;} = 7;
        public RpgClass Class {get; set;} = RpgClass.Witcher;
        
    }
}