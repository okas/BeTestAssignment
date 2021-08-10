using System;
using System.Collections.Generic;
using BeTestAssignment.Models;

namespace BeTestAssignment.Dtos
{
    public class CompanyDto
    {
        public CompanyDto(Company company)
        {
            Id = company.Id;
            Name = company.Name;
            Address = company.Address;
            CountryCode = company.CountryCode;
            RegistryCode = company.RegistryCode;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string CountryCode { get; set; }

        public string RegistryCode { get; set; }

        public ICollection<Contract> Contracts{ get; set; }
    }
}