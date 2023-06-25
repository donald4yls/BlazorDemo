using Ls.AdminApp.AdminAppContracts;
using Ls.AdminApp.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace Ls.AdminApp.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AdminAppPermissions.RoleManager.Default)]
    public class RoleController : AdminAppController, IRoleAppService
    {
        [HttpPost("Create")]
        public Task<IdentityRoleDto> CreateAsync(IdentityRoleCreateDto input)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("Delate/{id}")]
        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("All")]
        public Task<ListResultDto<IdentityRoleDto>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public Task<IdentityRoleDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("List")]
        [Authorize(AdminAppPermissions.RoleManager.Create)]
        public Task<PagedResultDto<IdentityRoleDto>> GetListAsync(GetIdentityRolesInput input)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public Task<IdentityRoleDto> UpdateAsync(Guid id, IdentityRoleUpdateDto input)
        {
            throw new NotImplementedException();
        }
    }
}
