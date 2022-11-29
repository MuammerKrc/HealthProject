using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.IdentityModels;

namespace CoreLayer.Dtos.IdentityDtos
{
    public class CreateUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public CreateUserDto GetNewUser()
        {
            return new CreateUserDto()
            {
                Password = this.Password,
                Name = this.Name,
                Surname = this.Surname,
                Email = this.Email,
            };
        }
    }
}
