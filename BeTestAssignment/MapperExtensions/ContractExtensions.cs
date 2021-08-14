using BeTestAssignment.Dtos;
using BeTestAssignment.Models;

namespace BeTestAssignment.MapperExtensions
{
    public static class ContractExtensions
    {
        public static Contract ToModel(this ContractDto source)
        {
            return new Contract
            {
                Id = source.Id,
                Occupation = source.Occupation,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                CompanyId = source.CompanyId,
                UserId = source.UserId
            };
        }

        public static ContractDto ToDTO(this Contract source)
        {
            return new ContractDto
            {
                Id = source.Id,
                Occupation = source.Occupation,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                CompanyId = source.CompanyId,
                UserId = source.UserId
            };
        }
    }
}