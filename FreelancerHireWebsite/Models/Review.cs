namespace FreelancerHireWebsite.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int JobPostingId { get; set; }
        public int FreelancerProfileId { get; set; }
        public int ClientId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
