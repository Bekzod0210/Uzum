using AutoMapper;
using Uzum.Aplication.Abstractions;

namespace Uzum.Aplication.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile(IHashService hashService)
        {
            //CreateMap<User, CustomerViewModel>();

            ////CreateMap<CreateCustomerModel, User>()
            ////    .ForMember(d => d.Role, o => o.MapFrom(s => UserRole.Client))
            ////    .ForMember(d => d.PasswordHash, o => o.MapFrom(s => hashProvider.GetHash(s.Password)));

            //CreateMap<UpdateCustomerModel, User>()
            //    .AfterMap((model, entity) =>
            //    {
            //        entity.PasswordHash = model.Password == null
            //            ? entity.PasswordHash
            //            : hashService.GetHash(model.Password);
            //    });
        }
    }
}
