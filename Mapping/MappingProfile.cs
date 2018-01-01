using System.Linq;
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
            CreateMap<Vehicle, VehicleResource>()
                .ForMember(vr => vr.Contact, opt => opt.MapFrom(v => new ContactResource
                 {  Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone  }))
                 .ForMember(vt => vt.Features, opt => opt.MapFrom(v => v.Features.Select(x=>x.FeatureId)));


            //api to domain resources 
             CreateMap<VehicleResource, Vehicle>()
                .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
                .ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name))
                .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email))
                .ForMember(v => v.Features, opt => opt.MapFrom(vt => vt.Features
                .Select(id => new VehicleFeature {  
                    FeatureId = id
                })));


            
        }
    }
}