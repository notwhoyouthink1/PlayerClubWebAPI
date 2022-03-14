using System.Globalization;

namespace PlayerClubWebAPI.Models
{
    public class Team
    {
        public string? Id { get; set; }
        public string? Ground { get; set; }
        public string? Coach { get; set; }
        public DateTime Founding { get; set; }
        public string? Region { get; set; }
        public List<Player>? CurrentPlayers { get; set; }
    }
}
