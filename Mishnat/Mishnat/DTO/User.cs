namespace Mishnat.NewFolder
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Tz { get; set; }
        public string Email { get; set; }
        public string  Phon { get; set; }
        public string Address { get; set; }
        public string StationId { get; set; }
        public DateOnly DateOfRegistration { get; set; }
    }
}
