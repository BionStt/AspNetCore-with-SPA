using AutoMapper;
using dotnetCore.Controllers.Resources;
using dotnetCore.model;
using S.Controllers.Resources;
using S.model;

namespace dotnetCore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Features, KeyValuePairResource>();
        }
    }
}