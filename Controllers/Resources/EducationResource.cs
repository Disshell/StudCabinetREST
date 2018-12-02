namespace StudCabinetREST.Controllers.Resources
{
    public class EducationResource
    {
   
        public int IdEducation { get; set; }
        public int IdInstitutionType { get; set; }
        public int IdCertificateType { get; set; }
        public string InstitutionName { get; set; }
        public int? Point { get; set; }

        public CertificateTypeResource IdCertificateTypeNavigation { get; set; }
        public InstitutionTypeResource IdInstitutionTypeNavigation { get; set; }
    }
}