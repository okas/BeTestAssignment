using System;

namespace BeTestAssignment.Models
{
    public class Contract
    {
        public Guid Id { get; set; }

        public string Occupation { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid CompanyId { get; set; }

        public string UserId { get; set; }

        public Company Company { get; set; }

        public ApplicationUser User { get; set; }
    }
}
