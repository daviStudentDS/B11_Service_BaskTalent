using Microsoft.AspNetCore.Mvc;
using BaskTalents.Models;
using System.Collections.Generic;

namespace BaskTalents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private static List<TeamModel> teams = new List<TeamModel>();

        // GET: api/Teams
        [HttpGet]
        public ActionResult<IEnumerable<TeamModel>> GetTeams()
        {
            return teams;
        }

        // GET: api/Teams/5
        [HttpGet("{id}")]
        public ActionResult<TeamModel> GetTeam(int id)
        {
            var team = teams.Find(t => t.TeamId == id);

            if (team == null)
            {
                return NotFound();
            }

            return team;
        }

        // POST: api/Teams
        [HttpPost]
        public void PostTeam([FromBody] TeamModel team)
        {
            teams.Add(team);
        }
    }
}