using AutoMapper;
using BP.Models.User;
using BP.Models.ViewModels;

namespace BP.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserVM, User>(); 
        }
    }
}
