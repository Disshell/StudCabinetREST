using AutoMapper;
using StudCabinetREST.Controllers.Resources;
using StudCabinetREST.Models;
using System.Linq;

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
            CreateMap<Exam, ExamResource>();
            CreateMap<ApplicationMainInfo, ApplicationMainInfoResource>();

            CreateMap<ApplicationMainInfoResource, ApplicationMainInfo>();
            CreateMap<PassportResource, Passport>();
            CreateMap<ExamResource, Exam>();
            //.ForMember(x => x.Passport, opt => opt.MapFrom(src => src.Passport));

        }
    }
}