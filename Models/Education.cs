using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class Education
    {
        public int IdEducation { get; set; }
        public int IdStudentInfo { get; set; }
        public int IdInstitutionType { get; set; }
        public int IdCertificateType { get; set; }
        public string InstitutionName { get; set; }
        public int? Point { get; set; }

        public CertificateType IdCertificateTypeNavigation { get; set; }
        public InstitutionType IdInstitutionTypeNavigation { get; set; }
        public ApplicationMainInfo IdStudentInfoNavigation { get; set; }
    }
}
