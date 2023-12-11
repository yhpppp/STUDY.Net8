using AutoMapper;
using STUDY.Net8.Model;

namespace STUDY.Net8.Extensions
{
    public class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<Role, RoleVo>().ForMember(a => a.RoleName, b => b.MapFrom(c => c.Name));
            CreateMap<RoleVo, Role>().ForMember(a => a.Name, b => b.MapFrom(c => c.RoleName));
        }
    }
}
