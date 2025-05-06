﻿namespace FreelancerHireWebsite.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public int JobPostingId { get; set; }
        public int FreelancerProfileId { get; set; }
        public string CoverLetter { get; set; }
        public DateTime AppliedAt { get; set; }
        public string Status { get; set; }
    }
}
