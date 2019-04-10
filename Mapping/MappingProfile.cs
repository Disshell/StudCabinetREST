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
            CreateMap<ApplicationMainInfo, ApplicationMainInfoResource>();
            CreateMap<Application, ApplicationResource>();
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

            CreateMap<ApplicationMainInfoResource, ApplicationMainInfo>()
                .ForMember(a => a.ApplicationMainInfoId, opt => opt.Ignore());
            CreateMap<ApplicationResource, Application>()
                .ForMember(a => a.ApplicationId, opt => opt.Ignore());
            CreateMap<CertificateTypeResource, CertificateType>();
            CreateMap<DirectionResource, Direction>();
            CreateMap<EducationResource, Education>();
            CreateMap<ExamResource, Exam>()
                .ForMember(e => e.ExamId, opt => opt.Ignore());
            CreateMap<FacultyResources, Faculty>();
            CreateMap<InstitutionTypeResource, InstitutionType>();
            CreateMap<MilitaryResource, Military>()
                .ForMember(m => m.MilitaryId, opt => opt.Ignore());
            CreateMap<ObjectResource, Object>();
            CreateMap<PrivilegeResource, Privilege>()
                .ForMember(p => p.PrivilegeId, opt => opt.Ignore());
            CreateMap<RewardResource, Reward>()
                .ForMember(r => r.RewardId, opt => opt.Ignore());
            CreateMap<SpecializationResource, Specialization>();
        }
    }
}