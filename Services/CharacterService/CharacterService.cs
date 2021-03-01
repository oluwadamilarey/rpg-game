using System.Collections.Generic;
using rpg_game.Models;
using System.Linq;

namespace rpg_game.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{ // Defining List of Characters.
            new Character(),
            new Character { id = 1, Name = "Juwon"}
        };

        public List<Character> AddCharacter(){
            characters.Add(newCharacter);
            return Ok(characters);
        }

        public List<Character> GetAllCharacters(){
            return Ok(characters);
        }
        public CharacterService GetCharacterById(int Id){
            return Ok(characters.FirstOrDefault(c => c.id == id));
        }
    }
} 