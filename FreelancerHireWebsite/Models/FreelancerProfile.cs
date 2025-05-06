namespace FreelancerHireWebsite.Models
{
    public class FreelancerProfile
    {
        public int FreelancerProfileId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public decimal HourlyRate { get; set; }
        public string ProfilePicture { get; set; }
        public string Location { get; set; }
    }
}
