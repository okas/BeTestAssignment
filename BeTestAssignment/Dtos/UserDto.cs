using System;
using BeTestAssignment.Models;

namespace BeTestAssignment.Dtos
{
    public class UserDto
    {
        public UserDto(ApplicationUser user)
        {
            Id = new Guid(user.Id);
            UserName = user.UserName;
            Email = user.Email;
            PhoneNumber = user.PhoneNumber;
        }

        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
