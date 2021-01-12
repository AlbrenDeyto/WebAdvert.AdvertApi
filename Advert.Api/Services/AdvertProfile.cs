using AdvertApi.Models;
using AutoMapper;

namespace Advert.Api.Services
{
    public class AdvertProfile : Profile
    {
        public AdvertProfile()
        {
            CreateMap<AdvertModel, AdvertDbModel>();
        }

    }
}
