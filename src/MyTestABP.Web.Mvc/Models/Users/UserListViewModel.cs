using System.Collections.Generic;
using MyTestABP.Roles.Dto;
using MyTestABP.Users.Dto;

namespace MyTestABP.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
