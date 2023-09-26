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
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, RequestProductDto>().ReverseMap();
            CreateMap<ProductBrand,RequestProductBrandDto>().ReverseMap();
            CreateMap<ProductBrand, ProductBrandDto>().ReverseMap();
            CreateMap<ProductType, RequestProductTypeDto>().ReverseMap();
            CreateMap<ProductType, ProductTypeDto>().ReverseMap();
        }
    }
}
