using Application.Dtos.Boat;
using Application.Requests.Boat;
using Application.Responses.Boat;
using AutoMapper;
using Core.Entities.Concrete;

namespace Application.Profiles.Mapping.AutoMapper
{
    public class BoatMapperProfiles : Profile
    {
        public BoatMapperProfiles()
        {
            CreateMap<CreateBoatRequest, Boat>();
            CreateMap<Boat, CreatedBoatResponse>();

            CreateMap<Boat, BoatListItemDto>();
            CreateMap<IList<Boat>, GetBoatListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<Boat, DeletedBoatResponse>();

            CreateMap<Boat, GetBoatByIdResponse>();

            CreateMap<UpdateBoatRequest, Boat>();
            CreateMap<Boat, UpdatedBoatResponse>();
        }
    }
}