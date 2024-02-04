using Microsoft.AspNetCore.Mvc;
using BaskTalents.Models;
using System.Collections.Generic;

namespace BaskTalents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private static List<PlayerModel> players = new List<PlayerModel>();

        // GET: api/Players
        [HttpGet]
        public ActionResult<IEnumerable<PlayerModel>> GetPlayers()
        {
            
            return players;
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public ActionResult<PlayerModel> GetPlayer(int id)
        {
            var player = players.Find(p => p.PlayerId == id);

            if (player == null)
            {
                return NotFound();
            }

            return player;
        }

        // POST: api/Players
        [HttpPost]
        public void PostPlayer([FromBody] PlayerModel player)
        {
            players.Add(player);
        }
    }
}
