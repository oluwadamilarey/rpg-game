using rpg_game.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using rpg_game.Dtos.Character; 

namespace rpg_game.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(Character newCharacter);
    }
}