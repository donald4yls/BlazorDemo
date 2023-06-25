using System;
using System.Collections.Generic;
using Volo.Abp.Identity;

namespace Ls.AdminApp.AdminAppContracts.Dtos
{
    public class CustomIdentityUserDto : IdentityUserDto
    {
        public List<string> RoleNames { get; set; }
    }

    public class CustomIdentityUserCreateDto: IdentityUserCreateDto
    {

    }
}
