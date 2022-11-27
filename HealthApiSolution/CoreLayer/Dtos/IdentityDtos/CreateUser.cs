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

        public AppUser GetNewUser()
        {
            return new AppUser()
            {
                FullName = (this.Name ?? "") + " " + (this.Surname ?? ""),

                Id = Guid.NewGuid().ToString(),
                Name = this.Name,
                Surname = this.Surname,
                Email = this.Email,
                UserName = Guid.NewGuid().ToString()
            };
        }
    }
}
