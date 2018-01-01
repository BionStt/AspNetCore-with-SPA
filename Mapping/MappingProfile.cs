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
            // domain to api resources 
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Features, KeyValuePairResource>();


            //api to domain resources 
            CreateMap<VehicleResource, Vehicle>()
            .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vt => vt.Contact.Phone))
            .ForMember(v => v.ContactName, opt => opt.MapFrom(vt => vt.Contact.Name))
            .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vt => vt.Contact.Email));
        }
    }
}