using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class CertificateType
    {
        public CertificateType()
        {
            Education = new HashSet<Education>();
        }

        public int IdCertificateType { get; set; }
        public string Name { get; set; }

        public ICollection<Education> Education { get; set; }
    }
}
