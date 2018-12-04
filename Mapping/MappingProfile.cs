using AutoMapper;
using StudCabinetREST.Controllers.Resources;
using StudCabinetREST.Models;

namespace StudCabinetREST.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile ()
        {
            CreateMap<Object, ObjectResource>();
        }
    }
}