using Ls.Abp.SharedLib.CustomFilters;
using Ls.AdminApp.AdminAppContracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace Ls.AdminApp.Controllers
{
    [Route("api/[controller]")]
    [Authorize(IdentityPermissions.Users.Default)]
    public class UserController : AdminAppController, IUserAppService
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost("Create")]
        public Task<IdentityUserDto> CreateAsync(IdentityUserCreateDto input)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("Delete/{id}")]
        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HiddenApi]
        [HttpGet("FindByEmailAsync/{email}")]
        public Task<IdentityUserDto> FindByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        [HiddenApi]
        [HttpGet("FindByUsernameAsync/{username}")]
        public Task<IdentityUserDto> FindByUsernameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        [HttpGet("GetAssignableRolesAsync")]
        public Task<ListResultDto<IdentityRoleDto>> GetAssignableRolesAsync()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public Task<IdentityUserDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("List")]
        public Task<PagedResultDto<IdentityUserDto>> GetListAsync(GetIdentityUsersInput input)
        {
            throw new NotImplementedException();
        }

        [HttpGet("Role/{id}")]
        public Task<ListResultDto<IdentityRoleDto>> GetRolesAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("Update")]
        public Task<IdentityUserDto> UpdateAsync(Guid id, IdentityUserUpdateDto input)
        {
            throw new NotImplementedException();
        }

        [HttpPut("UpdateRoles")]
        public Task UpdateRolesAsync(Guid id, IdentityUserUpdateRolesDto input)
        {
            throw new NotImplementedException();
        }
    }
}
