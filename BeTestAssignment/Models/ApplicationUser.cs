using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BeTestAssignment.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Contract> Contracts { get; set; }
    }
}
