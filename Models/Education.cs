using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Education
    {
        public int EducationId { get; set; }
        public int ApplicationMainInfoId { get; set; }
        public int InstitutionTypeId { get; set; }
        public int CertificateTypeId { get; set; }
        public string InstitutionName { get; set; }
        public int? Point { get; set; }

        public CertificateType CertificateType { get; set; }
        public InstitutionType InstitutionType { get; set; }
        public ApplicationMainInfo ApplicationMainInfo { get; set; }
    }
}
