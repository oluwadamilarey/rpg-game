using rpg_game.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rpg_game.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<List<Character>> GetAllCharacters();
         Task<Character> GetCharacterById(int id);
         Task<List<Character>> AddCharacter(Character newCharacter);
    }
}