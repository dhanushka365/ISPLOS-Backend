﻿using API.Dtos;
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
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User,RequestUserDTO>().ReverseMap();
            CreateMap<Product, RequestProductDto>().ReverseMap();
            CreateMap<ProductBrand,RequestProductBrandDto>().ReverseMap();
            CreateMap<ProductBrand, ProductBrandDto>().ReverseMap();
            CreateMap<ProductType, RequestProductTypeDto>().ReverseMap();
            CreateMap<ProductType, ProductTypeDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, RequestOrderDto>().ReverseMap();
            CreateMap<OrderStatus, OrderStatusDto>().ReverseMap();
            CreateMap<OrderStatus, RequestOrderStatusDto>().ReverseMap();
            CreateMap<OrderStatusType, OrderStatusTypeDto>().ReverseMap();
            CreateMap<OrderStatusType, RequestOrderStatusTypeDto>().ReverseMap();
            CreateMap<OrderProduct,OrderProductResponseDTO>().ReverseMap();
            CreateMap<OrderProduct ,OrderProductObjectResponseDTO>().ReverseMap();
            CreateMap<OrderProduct, OrderProductObjectDTO>().ReverseMap();
            CreateMap<Order, OrderProductObjectResponseDTO>().ReverseMap();
            CreateMap<User, UserMinimumDataDTO>().ReverseMap();

            //CreateMap<RequestOrderDto, Order>().ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems)).ReverseMap();




        }
    }
}
