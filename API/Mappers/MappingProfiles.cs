using API.Dtos;
using AutoMapper;
using Core.Entities.OrderAggregate;
using Core.Entities;
using Core.Entities.Identity;

namespace API.Mappers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Role,RoleDTO>().ReverseMap();
            CreateMap<Role,RequestRoleDTO>().ReverseMap();
                
        }
    }
}
