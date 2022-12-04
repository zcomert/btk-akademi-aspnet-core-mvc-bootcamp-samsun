using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace ProductApp.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductForInsertionDto, Product>();
            CreateMap<ProductForUpdateDto, Product>().ReverseMap();
         
        }
    }
}
