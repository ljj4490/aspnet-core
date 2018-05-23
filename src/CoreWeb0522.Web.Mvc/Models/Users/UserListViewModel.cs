using System.Collections.Generic;
using CoreWeb0522.Roles.Dto;
using CoreWeb0522.Users.Dto;

namespace CoreWeb0522.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
