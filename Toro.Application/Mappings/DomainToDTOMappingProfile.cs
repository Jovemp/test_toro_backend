using System;
using AutoMapper;
using Toro.Application.Models.Response;
using Toro.Domain.Entities;
using Toro.Application.Models.Request;
using Toro.Domain.Entities.Base;

namespace Toro.Application.Mappings
{
	public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<BondResponse, BondEntity>().ReverseMap();
            CreateMap<AccountResponse, AccountEntity>().ReverseMap();
            CreateMap<OrderResponse, OrderEntity>().ReverseMap();
            CreateMap<OrderRequestCreate, OrderEntity>().ReverseMap();
            CreateMap(typeof(PagedResult<>), typeof(PagedResult<>))
            .ForMember("Items", opt => opt.MapFrom("Items"))
            .ForMember("TotalCount", opt => opt.MapFrom("TotalCount"));
        }
    }
}

