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
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters(){
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }
        
        public async Task<ServiceResponse<Character>> GetCharacterById(int id){
            ServiceResponse<Character> serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.id == id);
            return serviceResponse;
        }
    } 
} 