using AutoMapper;

namespace STUDY.Net8.Extensions
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg => cfg.AddProfile(new CustomProfile()));
        }
    }
}
