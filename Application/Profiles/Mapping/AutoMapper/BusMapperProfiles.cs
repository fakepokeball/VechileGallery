using Application.Dtos.Bus;
using Application.Requests.Bus;
using Application.Responses.Bus;
using AutoMapper;
using Core.Entities.Concrete;

namespace Application.Profiles.Mapping.AutoMapper
{
    public class BusMapperProfiles : Profile
    {
        public BusMapperProfiles()
        {
            CreateMap<CreateBusRequest, Bus>();
            CreateMap<Bus, CreatedBusResponse>();

            CreateMap<Bus, BusListItemDto>();
            CreateMap<IList<Bus>, GetBusListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<Bus, DeletedBusResponse>();

            CreateMap<Bus, GetBusByIdResponse>();

            CreateMap<UpdateBusRequest, Bus>();
            CreateMap<Bus, UpdatedBusResponse>();
        }
    }
}
