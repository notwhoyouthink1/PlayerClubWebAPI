using System.Globalization;

namespace PlayerClubWebAPI.Models
{
    public class Player
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string? BirthPlace { get; set; }
    }
}
