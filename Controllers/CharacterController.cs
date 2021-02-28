using rpg_game.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

        [Route("GetAll")]
        public IActionResult Get(){ // get request for returning a list of characters
            return Ok(characters); // Remember Ok method refefrs to hdefining the status code for operation which in this case case is status 200 for success
        }

        [HttpGet("{id}")] // parameter for routing, the parameter for the route has to match the nname for the fuction parameter.
        public IActionResult GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.id == id));
        }

        public IActionResult AddCharacter(Character newCharacter){
            
        }
    }
}