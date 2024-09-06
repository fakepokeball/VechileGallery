using Application.Dtos.Car;
using Application.Requests.Car;
using Application.Responses.Car;
using AutoMapper;
using Core.Entities.Concrete;

namespace Application.Profiles.Mapping.AutoMapper
{
    public class CarMapperProfiles : Profile
    {
        public CarMapperProfiles()
        {
            CreateMap<CreateCarRequest, Car>();
            CreateMap<Car, CreatedCarResponse>();

            CreateMap<Car, CarListItemDto>();
            CreateMap<IList<Car>, GetCarListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<Car, DeletedCarResponse>();

            CreateMap<Car, GetCarByIdResponse>();

            CreateMap<UpdateCarRequest, Car>();
            CreateMap<Car, UpdatedCarResponse>();

            CreateMap<ToggleHeadlightsRequest, Car>()
            .ForMember(dest => dest.HeadlightsOn, opt => opt.MapFrom(src => src.HeadlightsOn));
        }
    }
}
