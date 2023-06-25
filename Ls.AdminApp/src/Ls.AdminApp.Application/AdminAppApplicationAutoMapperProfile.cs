using AutoMapper;
using Ls.AdminApp.AdminAppContracts.Dtos;
using Volo.Abp.Identity;

namespace Ls.AdminApp;

public class AdminAppApplicationAutoMapperProfile : Profile
{
    public AdminAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<IdentityUser, CustomIdentityUserDto>();
    }
}
