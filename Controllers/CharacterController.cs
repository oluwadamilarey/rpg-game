using rpg_game.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using rpg_game.Services.CharacterService;

namespace rpg_game.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> characters = new List<Character>{ // Defining List of Characters.
            new Character(),
            new Character { id = 1, Name = "Juwon"}
        }; 

        private readOnly ICharacterService _characterService;// raedonly means it can only be assigned in the contructor.

        public CharacterController(ICharacterService chracterService){ //this is class constructor

        }

        [Route("GetAll")]
        public IActionResult Get(){ // get request for returning a list of characters
            return Ok(characters); // Remember Ok method refers to defining the status code for operation which in this case case is status 200 for success
        }

        [HttpGet("{id}")] // parameter for routing, the parameter for the route has to match the nname for the fuction parameter.
        public IActionResult GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.id == id));
        }
        
        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter){
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}