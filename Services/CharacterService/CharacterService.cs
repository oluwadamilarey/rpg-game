using System.Collections.Generic;
using rpg_game.Models;
using System.Linq;
using System.Threading.Tasks;
using rpg_game.Dtos.Character;

namespace rpg_game.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{ // Defining List of Characters.
            new Character(),
            new Character { id = 1, Name = "Juwon"}
        };

        private readonly Imapper _mapper;

        public CharacterService(IMapper mapper){
            _mapper = mapper
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter){
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            characters.Add(_mapper.Map<Character>(newCharacter));
            serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters(){
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }
        
        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id){
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.id == id));
            return serviceResponse;
        }
    } 
}