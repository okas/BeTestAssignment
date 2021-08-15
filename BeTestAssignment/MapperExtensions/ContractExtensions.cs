using BeTestAssignment.Dtos;
using BeTestAssignment.Models;

namespace BeTestAssignment.MapperExtensions
{
    public static class ContractExtensions
    {
        public static Contract ToModel(this ContractDto source)
        {
            var model = ToModel(source);
            model.Id = source.Id;
            return model;
        }

        public static ContractDto ToDTO(this Contract source)
        {
            var model = (ContractDto)ToNewDTO(source);
            model.Id = source.Id;
            return model;
        }

        public static Contract ToModel(this ContractNewDto source)
        {
            return new Contract
            {
                Occupation = source.Occupation,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                CompanyId = source.CompanyId,
                UserId = source.UserId
            };
        }

        public static ContractNewDto ToNewDTO(this Contract source)
        {
            return new ContractDto
            {
                Occupation = source.Occupation,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                CompanyId = source.CompanyId,
                UserId = source.UserId
            };
        }
    }
}