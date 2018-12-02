using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Education
    {
        public int IdEducation { get; set; }
        public int IdApplicationMainInfo { get; set; }
        public int IdInstitutionType { get; set; }
        public int IdCertificateType { get; set; }
        public string InstitutionName { get; set; }
        public int? Point { get; set; }

        public CertificateType IdCertificateTypeNavigation { get; set; }
        public InstitutionType IdInstitutionTypeNavigation { get; set; }
        public ApplicationMainInfo IdApplicationMainInfoNavigation { get; set; }
    }
}
