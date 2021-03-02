using System.Collections.Generic;
using rpg_game.Models;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_game.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{ // Defining List of Characters.
            new Character(),
            new Character { id = 1, Name = "Juwon"}
        };

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter){
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters(){
            return characters;
        }
        
        public async Task<ServiceResponse<Character>> GetCharacterById(int id){
            return characters.FirstOrDefault(c => c.id == id);
        }
    } 
} 