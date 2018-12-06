namespace StudCabinetREST.Controllers.Resources
{
    public class EducationResource
    {
   
        public int EducationId { get; set; }
        public int InstitutionTypeId { get; set; }
        public int CertificateTypeId { get; set; }
        public string InstitutionName { get; set; }
        public int? Point { get; set; }

        public CertificateTypeResource IdCertificateTypeNavigation { get; set; }
        public InstitutionTypeResource IdInstitutionTypeNavigation { get; set; }
    }
}