namespace Mishnat.NewFolder
{
    public class User
    {
        public int UserId { get; set; } = 0;
        public string Name { get; set; } = "ruchami";
        public string Tz { get; set; } = "12456789";
        public string Email { get; set; }
        public string  Phon { get; set; }
        public string Address { get; set; }
        public int StationId { get; set; }
        public DateOnly DateOfRegistration { get; set; }
    }
}
