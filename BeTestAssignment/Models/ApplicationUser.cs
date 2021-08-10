using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BeTestAssignment.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
