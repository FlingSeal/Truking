using AutoMapper;

namespace Truking.Models.Dto
{
    public class DtoMappingProfile:Profile
    {
        public DtoMappingProfile() 
        {
            CreateMap<User,UserDto>().ReverseMap();
        }
    }
}
