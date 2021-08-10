using System;
using System.Collections.Generic;

namespace BeTestAssignment.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string CountryCode { get; set; }

        public string RegistryCode { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
