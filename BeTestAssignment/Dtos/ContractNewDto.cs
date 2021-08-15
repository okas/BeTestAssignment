using System;
using System.ComponentModel.DataAnnotations;

namespace BeTestAssignment.Dtos
{
    public class ContractNewDto
    {
        [Required]
        public string Occupation { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public Guid CompanyId { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
