namespace FreelancerHireWebsite.Models
{
    public class JobPosting
    {
        public int JobPostingId { get; set; }
        public int ClientId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public DateTime Deadline { get; set; }
        public int CategoryId { get; set; }
        public DateTime PostedAt { get; set; }
        public string Status { get; set; }
    }
}
