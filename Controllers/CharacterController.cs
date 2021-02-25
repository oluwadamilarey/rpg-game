using rpg_game.Models;
using Microsoft.AspNetCore.Mvc;

namespace rpg_game.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private static Character Knight = new Character(); 
    }
}