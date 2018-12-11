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
            CreateMap<Application, ApplicationResource>();
            CreateMap<ApplicationMainInfo, ApplicationMainInfoResource>();
            CreateMap<CertificateType, CertificateTypeResource>();
            CreateMap<Direction, DirectionResource>();
            CreateMap<Education, EducationResource>();
            CreateMap<Exam, ExamResource>();
            CreateMap<Faculty, FacultyResources>();
            CreateMap<InstitutionType, InstitutionTypeResource>();
            CreateMap<Military, MilitaryResource>();
            CreateMap<Object, ObjectResource>();
            CreateMap<Passport, PassportResource>();
            CreateMap<Privilege, PrivilegeResource>();
            CreateMap<Reward, RewardResource>();
            CreateMap<Specialization, SpecializationResource>();

            CreateMap<ApplicationResource, Application>();
            CreateMap<ApplicationMainInfoResource, ApplicationMainInfo>();
            CreateMap<CertificateTypeResource, CertificateType>();
            CreateMap<DirectionResource, Direction>();
            CreateMap<EducationResource, Education>();
            CreateMap<ExamResource, Exam>();
            CreateMap<FacultyResources, Faculty>();
            CreateMap<InstitutionTypeResource, InstitutionType>();
            CreateMap<MilitaryResource, Military>();
            CreateMap<ObjectResource, Object>();
            CreateMap<PassportResource, Passport>();
            CreateMap<PrivilegeResource, Privilege>();
            CreateMap<RewardResource, Reward>();
            CreateMap<SpecializationResource, Specialization>();
        }
    }
}