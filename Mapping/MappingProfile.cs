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
            CreateMap<CertificateType, CertificateTypeResource>();
            CreateMap<InstitutionType, InstitutionTypeResource>();
            CreateMap<Direction, DirectionResource>();
            CreateMap<Specialization, SpecializationResource>();
            CreateMap<Faculty, FacultyResources>();
        }
    }
}