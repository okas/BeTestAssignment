using BeTestAssignment.Models;
using System;

namespace BeTestAssignment.Dtos
{
    public class ContractDto
    {
        public ContractDto(Contract model)
        {
            Id = model.Id;
            Occupation = model.Occupation;
            StartDate = model.StartDate;
            EndDate = model.EndDate;
        }

        public Guid Id { get; set; }

        public string Occupation { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid CompanyId { get; set; }

        public string UserId { get; set; }
    }
}
