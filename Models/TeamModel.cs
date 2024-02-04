using System.ComponentModel.DataAnnotations;

namespace BaskTalents.Models
{
    public class TeamModel
    {
        public int TeamId { get; set; }

        [Required]
        public string TeamName { get; set; }

        public int NumberOfPlayers { get; set; }

        public string TeamDescription { get; set; }
    }
}
