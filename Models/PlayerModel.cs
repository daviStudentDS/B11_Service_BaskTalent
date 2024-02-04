using System.ComponentModel.DataAnnotations;

namespace BaskTalents.Models
{
    public class PlayerModel
    {
        public int PlayerId { get; set; }

        [Required]
        public string PlayerName { get; set; }

        [EmailAddress]
        public string PlayerEmail { get; set; }

        [Phone]
        public string PlayerPhoneNumber { get; set; }

        public string PlayerGender { get; set; }

        public double PlayerHeight { get; set; }

        public double PlayerWeight { get; set; }

        public string PlayerPosition { get; set; }

        public string PlayerDescription { get; set; }
    }


}
