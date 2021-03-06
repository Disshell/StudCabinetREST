﻿using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class CertificateType
    {
        public CertificateType()
        {
            Education = new HashSet<Education>();
        }

        public int CertificateTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Education> Education { get; set; }
    }
}
