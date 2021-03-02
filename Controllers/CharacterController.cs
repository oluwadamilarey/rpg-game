using rpg_game.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using rpg_game.Services.CharacterService;
using System.Threading.Tasks;

namespace rpg_game.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private readonly ICharacterService _characterService;// raedonly means it can only be assigned in the contructor.

        public CharacterController(ICharacterService characterService){ //this is class constructor
            _characterService = characterService;
        }

        [Route("GetAll")]
        public async Task<IActionResult> Get(){ // get request for returning a list of characters
            return Ok(_characterService.GetAllCharacters()); // Remember Ok method refers to defining the status code for operation which in this case case is status 200 for success
        }

        [HttpGet("{id}")] // parameter for routing, the parameter for the route has to match the nname for the fuction parameter.
        public async Task<IActionResult> GetSingle(int id){
            return Ok(_characterService.GetCharacterById(id));
        }
        
        [HttpPost]
        public async Task<IActionResult> AddCharacter(Character newCharacter){ 
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}