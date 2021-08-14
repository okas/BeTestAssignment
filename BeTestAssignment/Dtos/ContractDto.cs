using BeTestAssignment.Models;
using System;

namespace BeTestAssignment.Dtos
{
    public class ContractDto
    {
        public Guid Id { get; set; }

        public string Occupation { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid CompanyId { get; set; }

        public string UserId { get; set; }
    }
}
